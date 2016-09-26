using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallJson
{
    public partial class ControlCallJson : UserControl
    {
        private Cursor bakCursor;
        private const string JSON_FILTER = "Json file|*.json|Text file|*.txt|All files|*.*";
        private const string TEXT_FILTER = "Text file|*.txt|All files|*.*";

        enum Verbs
        {
            GET, POST, PUT, DELETE
        };

        public ControlCallJson()
        {
            InitializeComponent();
        }


        private void btnGET_Click(object sender, EventArgs e)
        {
            ApplyVerbButton(btnGET);
        }

        private void ApplyVerbButton(ToolStripButton button)
        {

            UncheckVerbButtons();
            button.Checked = true;
            ShowBodyItems();
        }

        private void ShowBodyItems()
        {
            stripBody.Visible = btnPUT.Checked || btnPOST.Checked;
            txtJsonBody.Visible = stripBody.Visible;
        }

        private void btnPOST_Click(object sender, EventArgs e)
        {
            ApplyVerbButton(btnPOST);
        }

        private void btnPUT_Click(object sender, EventArgs e)
        {
            ApplyVerbButton(btnPUT);
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            ApplyVerbButton(btnDELETE);
        }

        private void UncheckVerbButtons()
        {
            btnGET.Checked = false;
            btnPOST.Checked = false;
            btnPUT.Checked = false;
            btnDELETE.Checked = false;
        }


        private void Execute()
        {
            Verbs verb = GetVerbFromSelectedButton();
            tabs.SelectedTab = tabResults;
            EnableButtons(enabled: false);
            string result = string.Empty;
            try
            {
                Dictionary<string, string> headers = GenerateHeaders();
                switch (verb)
                {
                    case Verbs.GET:
                        result = JsonControler.GET(cmboURI.Text, headers);
                        break;
                    case Verbs.PUT:
                        result = JsonControler.PUT(cmboURI.Text, headers, txtJsonBody.Text);
                        break;
                    case Verbs.POST:
                        result = JsonControler.POST(cmboURI.Text, headers, txtJsonBody.Text);
                        break;
                    case Verbs.DELETE:
                        result = JsonControler.DELETE(cmboURI.Text, headers);
                        break;
                }

                txtResults.Text = result;

            }
            catch (Exception ex)
            {
                txtResults.Text = ex.Message;
            }
            EnableButtons(enabled: true);

        }

        private void EnableButtons(bool enabled)
        {
            btnBar1.Enabled = enabled;
            if (enabled)
            {
                this.Cursor = bakCursor;
            }
            else
            {
                bakCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;

            }
        }

        private Dictionary<string, string> GenerateHeaders()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            foreach (string line in txtHeaders.Lines)
            {
                if (!string.IsNullOrEmpty(line) && !line.StartsWith("#"))
                {
                    string[] values = line.Split(',');
                    string key = values[0].Replace("\"", "");
                    string value = values[1].Replace("\"", "");
                    headers.Add(key, value);
                }
            }
            return headers;
        }

        private void ControlCallJson_Load(object sender, EventArgs e)
        {
            ShowBodyItems();
        }


        private void btnExec_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private Verbs GetVerbFromSelectedButton()
        {
            if (btnGET.Checked)
            {
                return Verbs.GET;
            }
            else if (btnPOST.Checked)
            {
                return Verbs.POST;
            }
            else if (btnPUT.Checked)
            {
                return Verbs.PUT;
            }
            else if (btnDELETE.Checked)
            {
                return Verbs.DELETE;
            }
            else
            {
                return Verbs.GET;
            }
        }

        private void cmboURI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
                Execute();
            }
        }

        private void btnOpenBody_Click(object sender, EventArgs e)
        {
            OpenAndAssignFileContent(txtResults, JSON_FILTER);
        }

        private void OpenAndAssignFileContent(TextBox textBox, string filter)
        {
            string fileContent = OpenFile(filter);
            if (fileContent != null)
            {
                textBox.Text = fileContent;
            }
        }

        private string OpenFile(string filter)
        {
            string content = null;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = filter;
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        content = System.IO.File.ReadAllText(ofd.FileName);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return content;
        }

        private void btnOpenHeaders_Click(object sender, EventArgs e)
        {
            OpenAndAssignFileContent(txtHeaders, TEXT_FILTER);
        }

        private void btnSaveBody_Click(object sender, EventArgs e)
        {
            SaveFileContent(txtJsonBody.Text, JSON_FILTER);
        }

        private void SaveFileContent(string content, string filter)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = filter;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.IO.File.WriteAllText(sfd.FileName, content);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnSaveHeaders_Click(object sender, EventArgs e)
        {
            SaveFileContent(txtHeaders.Text, TEXT_FILTER);
        }

        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            SaveFileContent(txtResults.Text, JSON_FILTER);
        }

        private void btnCreateJsonClass_Click(object sender, EventArgs e)
        {
        }
    }
}
