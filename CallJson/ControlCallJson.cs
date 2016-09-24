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
        public ControlCallJson()
        {
            InitializeComponent();
        }

        private void btnGET_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> headers = GenerateHeaders();
                txtResults.Text = JsonControler.GET(cmboURI.Text, headers);

            }
            catch (Exception ex)
            {
                txtResults.Text = ex.Message;
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

        }

        private void btnPOST_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> headers = GenerateHeaders();
                txtResults.Text = JsonControler.POST(cmboURI.Text, headers, txtJsonBody.Text);
            }
            catch (Exception ex)
            {
                txtResults.Text = ex.Message;
            }
        }

        private void btnPUT_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> headers = GenerateHeaders();
                txtResults.Text = JsonControler.PUT(cmboURI.Text, headers, txtJsonBody.Text);
            }
            catch (Exception ex)
            {
                txtResults.Text = ex.Message;
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> headers = GenerateHeaders();
                txtResults.Text = JsonControler.DELETE(cmboURI.Text, headers);
            }
            catch (Exception ex)
            {
                txtResults.Text = ex.Message;
            }
        }
    }
}
