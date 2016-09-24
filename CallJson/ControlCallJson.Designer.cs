namespace CallJson
{
    partial class ControlCallJson
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.cmboURI = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.txtHeaders = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGET = new System.Windows.Forms.ToolStripButton();
            this.btnPOST = new System.Windows.Forms.ToolStripButton();
            this.btnPUT = new System.Windows.Forms.ToolStripButton();
            this.btnDELETE = new System.Windows.Forms.ToolStripButton();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtJsonBody = new System.Windows.Forms.TextBox();
            this.pnlAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddress
            // 
            this.pnlAddress.Controls.Add(this.cmboURI);
            this.pnlAddress.Controls.Add(this.label1);
            this.pnlAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddress.Location = new System.Drawing.Point(0, 0);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(696, 27);
            this.pnlAddress.TabIndex = 0;
            // 
            // cmboURI
            // 
            this.cmboURI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmboURI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cmboURI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmboURI.FormattingEnabled = true;
            this.cmboURI.Location = new System.Drawing.Point(35, 0);
            this.cmboURI.Name = "cmboURI";
            this.cmboURI.Size = new System.Drawing.Size(661, 21);
            this.cmboURI.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "URI : ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtResults);
            this.splitContainer1.Size = new System.Drawing.Size(696, 351);
            this.splitContainer1.SplitterDistance = 139;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 114);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.txtHeaders);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(688, 88);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Headers";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // txtHeaders
            // 
            this.txtHeaders.AcceptsReturn = true;
            this.txtHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHeaders.Location = new System.Drawing.Point(0, 0);
            this.txtHeaders.Multiline = true;
            this.txtHeaders.Name = "txtHeaders";
            this.txtHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHeaders.Size = new System.Drawing.Size(688, 88);
            this.txtHeaders.TabIndex = 0;
            this.txtHeaders.Text = "#Enter custom headers hereunder\r\n#format is \"header name\",\"header value\"\r\n#sample" +
    " here for user-agent\r\n\"User-Agent\",\"Call Json\"\r\n";
            this.txtHeaders.WordWrap = false;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.txtJsonBody);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(688, 88);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Request body";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGET,
            this.btnPOST,
            this.btnPUT,
            this.btnDELETE});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(696, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGET
            // 
            this.btnGET.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGET.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(32, 22);
            this.btnGET.Text = "GET";
            this.btnGET.Click += new System.EventHandler(this.btnGET_Click);
            // 
            // btnPOST
            // 
            this.btnPOST.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPOST.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPOST.Name = "btnPOST";
            this.btnPOST.Size = new System.Drawing.Size(40, 22);
            this.btnPOST.Text = "POST";
            this.btnPOST.Click += new System.EventHandler(this.btnPOST_Click);
            // 
            // btnPUT
            // 
            this.btnPUT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPUT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPUT.Name = "btnPUT";
            this.btnPUT.Size = new System.Drawing.Size(33, 22);
            this.btnPUT.Text = "PUT";
            this.btnPUT.Click += new System.EventHandler(this.btnPUT_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDELETE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(50, 22);
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // txtResults
            // 
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Location = new System.Drawing.Point(0, 0);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(696, 208);
            this.txtResults.TabIndex = 0;
            // 
            // txtJsonBody
            // 
            this.txtJsonBody.AcceptsReturn = true;
            this.txtJsonBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJsonBody.Location = new System.Drawing.Point(0, 0);
            this.txtJsonBody.Multiline = true;
            this.txtJsonBody.Name = "txtJsonBody";
            this.txtJsonBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJsonBody.Size = new System.Drawing.Size(688, 88);
            this.txtJsonBody.TabIndex = 1;
            this.txtJsonBody.WordWrap = false;
            // 
            // ControlCallJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlAddress);
            this.Name = "ControlCallJson";
            this.Size = new System.Drawing.Size(696, 378);
            this.Load += new System.EventHandler(this.ControlCallJson_Load);
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGET;
        private System.Windows.Forms.ToolStripButton btnPOST;
        private System.Windows.Forms.ToolStripButton btnPUT;
        private System.Windows.Forms.ToolStripButton btnDELETE;
        private System.Windows.Forms.ComboBox cmboURI;
        private System.Windows.Forms.TextBox txtHeaders;
        private System.Windows.Forms.TextBox txtJsonBody;
    }
}
