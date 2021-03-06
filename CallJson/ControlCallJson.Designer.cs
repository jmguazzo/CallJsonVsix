﻿namespace CallJson
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCallJson));
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.cmboURI = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBar1 = new System.Windows.Forms.ToolStrip();
            this.btnGET = new System.Windows.Forms.ToolStripButton();
            this.btnPOST = new System.Windows.Forms.ToolStripButton();
            this.btnPUT = new System.Windows.Forms.ToolStripButton();
            this.btnDELETE = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExec = new System.Windows.Forms.ToolStripButton();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.txtJsonBody = new System.Windows.Forms.TextBox();
            this.stripBody = new System.Windows.Forms.ToolStrip();
            this.btnOpenBody = new System.Windows.Forms.ToolStripButton();
            this.btnSaveBody = new System.Windows.Forms.ToolStripButton();
            this.lblNotAvailableGetAndDelete = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.txtHeaders = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnOpenHeaders = new System.Windows.Forms.ToolStripButton();
            this.btnSaveHeaders = new System.Windows.Forms.ToolStripButton();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnSaveResults = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvFavorite = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddFavorite = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCreateFolder = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteFavorite = new System.Windows.Forms.ToolStripButton();
            this.pnlAddress.SuspendLayout();
            this.btnBar1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.stripBody.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabResults.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddress
            // 
            this.pnlAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAddress.Controls.Add(this.cmboURI);
            this.pnlAddress.Controls.Add(this.label1);
            this.pnlAddress.Controls.Add(this.btnBar1);
            this.pnlAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddress.Location = new System.Drawing.Point(0, 0);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(548, 52);
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
            this.cmboURI.Size = new System.Drawing.Size(513, 21);
            this.cmboURI.TabIndex = 2;
            this.cmboURI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmboURI_KeyDown);
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
            // btnBar1
            // 
            this.btnBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGET,
            this.btnPOST,
            this.btnPUT,
            this.btnDELETE,
            this.toolStripSeparator1,
            this.btnExec});
            this.btnBar1.Location = new System.Drawing.Point(0, 27);
            this.btnBar1.Name = "btnBar1";
            this.btnBar1.Size = new System.Drawing.Size(548, 25);
            this.btnBar1.TabIndex = 3;
            this.btnBar1.Text = "toolStrip1";
            // 
            // btnGET
            // 
            this.btnGET.Checked = true;
            this.btnGET.CheckOnClick = true;
            this.btnGET.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnGET.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGET.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(32, 22);
            this.btnGET.Text = "GET";
            this.btnGET.Click += new System.EventHandler(this.btnGET_Click);
            // 
            // btnPOST
            // 
            this.btnPOST.CheckOnClick = true;
            this.btnPOST.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPOST.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPOST.Name = "btnPOST";
            this.btnPOST.Size = new System.Drawing.Size(40, 22);
            this.btnPOST.Text = "POST";
            this.btnPOST.Click += new System.EventHandler(this.btnPOST_Click);
            // 
            // btnPUT
            // 
            this.btnPUT.CheckOnClick = true;
            this.btnPUT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPUT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPUT.Name = "btnPUT";
            this.btnPUT.Size = new System.Drawing.Size(33, 22);
            this.btnPUT.Text = "PUT";
            this.btnPUT.Click += new System.EventHandler(this.btnPUT_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.CheckOnClick = true;
            this.btnDELETE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDELETE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(50, 22);
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExec
            // 
            this.btnExec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExec.Image = global::CallJson.Images.Run_32x;
            this.btnExec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(23, 22);
            this.btnExec.Text = "Exec";
            this.btnExec.ToolTipText = "Execute action";
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage9);
            this.tabs.Controls.Add(this.tabPage8);
            this.tabs.Controls.Add(this.tabResults);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 52);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(548, 326);
            this.tabs.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.LightGray;
            this.tabPage9.Controls.Add(this.txtJsonBody);
            this.tabPage9.Controls.Add(this.stripBody);
            this.tabPage9.Controls.Add(this.lblNotAvailableGetAndDelete);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(540, 300);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Request body";
            // 
            // txtJsonBody
            // 
            this.txtJsonBody.AcceptsReturn = true;
            this.txtJsonBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJsonBody.Location = new System.Drawing.Point(0, 25);
            this.txtJsonBody.Multiline = true;
            this.txtJsonBody.Name = "txtJsonBody";
            this.txtJsonBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJsonBody.Size = new System.Drawing.Size(540, 275);
            this.txtJsonBody.TabIndex = 1;
            this.txtJsonBody.WordWrap = false;
            // 
            // stripBody
            // 
            this.stripBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stripBody.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenBody,
            this.btnSaveBody});
            this.stripBody.Location = new System.Drawing.Point(0, 0);
            this.stripBody.Name = "stripBody";
            this.stripBody.Size = new System.Drawing.Size(540, 25);
            this.stripBody.TabIndex = 4;
            this.stripBody.Text = "toolStrip1";
            // 
            // btnOpenBody
            // 
            this.btnOpenBody.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenBody.Image = global::CallJson.Images.OpenFolder_32x;
            this.btnOpenBody.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenBody.Name = "btnOpenBody";
            this.btnOpenBody.Size = new System.Drawing.Size(23, 22);
            this.btnOpenBody.Text = "Open body";
            this.btnOpenBody.Click += new System.EventHandler(this.btnOpenBody_Click);
            // 
            // btnSaveBody
            // 
            this.btnSaveBody.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveBody.Image = global::CallJson.Images.Save_32x;
            this.btnSaveBody.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveBody.Name = "btnSaveBody";
            this.btnSaveBody.Size = new System.Drawing.Size(23, 22);
            this.btnSaveBody.Text = "Save body";
            this.btnSaveBody.Click += new System.EventHandler(this.btnSaveBody_Click);
            // 
            // lblNotAvailableGetAndDelete
            // 
            this.lblNotAvailableGetAndDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotAvailableGetAndDelete.Location = new System.Drawing.Point(0, 0);
            this.lblNotAvailableGetAndDelete.Name = "lblNotAvailableGetAndDelete";
            this.lblNotAvailableGetAndDelete.Size = new System.Drawing.Size(540, 300);
            this.lblNotAvailableGetAndDelete.TabIndex = 5;
            this.lblNotAvailableGetAndDelete.Text = "Not available for GET and DELETE";
            this.lblNotAvailableGetAndDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.LightGray;
            this.tabPage8.Controls.Add(this.txtHeaders);
            this.tabPage8.Controls.Add(this.toolStrip2);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(540, 300);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Headers";
            // 
            // txtHeaders
            // 
            this.txtHeaders.AcceptsReturn = true;
            this.txtHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHeaders.Location = new System.Drawing.Point(0, 25);
            this.txtHeaders.Multiline = true;
            this.txtHeaders.Name = "txtHeaders";
            this.txtHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHeaders.Size = new System.Drawing.Size(540, 275);
            this.txtHeaders.TabIndex = 0;
            this.txtHeaders.Text = "#Enter custom headers hereunder\r\n#format is \"header name\",\"header value\"\r\n#sample" +
    " here for user-agent\r\n\"User-Agent\",\"Call Json\"\r\n";
            this.txtHeaders.WordWrap = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenHeaders,
            this.btnSaveHeaders});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(540, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnOpenHeaders
            // 
            this.btnOpenHeaders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenHeaders.Image = global::CallJson.Images.OpenFolder_32x;
            this.btnOpenHeaders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenHeaders.Name = "btnOpenHeaders";
            this.btnOpenHeaders.Size = new System.Drawing.Size(23, 22);
            this.btnOpenHeaders.Text = "Open headers";
            this.btnOpenHeaders.Click += new System.EventHandler(this.btnOpenHeaders_Click);
            // 
            // btnSaveHeaders
            // 
            this.btnSaveHeaders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveHeaders.Image = global::CallJson.Images.Save_32x;
            this.btnSaveHeaders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveHeaders.Name = "btnSaveHeaders";
            this.btnSaveHeaders.Size = new System.Drawing.Size(23, 22);
            this.btnSaveHeaders.Text = "Save headers";
            this.btnSaveHeaders.Click += new System.EventHandler(this.btnSaveHeaders_Click);
            // 
            // tabResults
            // 
            this.tabResults.BackColor = System.Drawing.Color.LightGray;
            this.tabResults.Controls.Add(this.txtResults);
            this.tabResults.Controls.Add(this.toolStrip3);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Size = new System.Drawing.Size(540, 300);
            this.tabResults.TabIndex = 2;
            this.tabResults.Text = "Results";
            // 
            // txtResults
            // 
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Location = new System.Drawing.Point(0, 25);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(540, 275);
            this.txtResults.TabIndex = 0;
            this.txtResults.WordWrap = false;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveResults});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(540, 25);
            this.toolStrip3.TabIndex = 6;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveResults.Image = global::CallJson.Images.Save_32x;
            this.btnSaveResults.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(23, 22);
            this.btnSaveResults.Text = "Save results";
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabs);
            this.splitContainer1.Panel1.Controls.Add(this.pnlAddress);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.trvFavorite);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(696, 378);
            this.splitContainer1.SplitterDistance = 548;
            this.splitContainer1.TabIndex = 1;
            // 
            // trvFavorite
            // 
            this.trvFavorite.AllowDrop = true;
            this.trvFavorite.BackColor = System.Drawing.SystemColors.Control;
            this.trvFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvFavorite.ImageIndex = 0;
            this.trvFavorite.ImageList = this.imageList1;
            this.trvFavorite.LabelEdit = true;
            this.trvFavorite.Location = new System.Drawing.Point(0, 25);
            this.trvFavorite.Name = "trvFavorite";
            this.trvFavorite.SelectedImageIndex = 0;
            this.trvFavorite.ShowNodeToolTips = true;
            this.trvFavorite.Size = new System.Drawing.Size(144, 353);
            this.trvFavorite.TabIndex = 0;
            this.trvFavorite.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.trvFavorite_AfterLabelEdit);
            this.trvFavorite.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.trvFavorite_ItemDrag);
            this.trvFavorite.DragDrop += new System.Windows.Forms.DragEventHandler(this.trvFavorite_DragDrop);
            this.trvFavorite.DragEnter += new System.Windows.Forms.DragEventHandler(this.trvFavorite_DragEnter);
            this.trvFavorite.DoubleClick += new System.EventHandler(this.trvFavorite_DoubleClick);
            this.trvFavorite.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trvFavorite_KeyUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder_grey_16x.png");
            this.imageList1.Images.SetKeyName(1, "Favorite_16xMD.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFavorite,
            this.toolStripSeparator2,
            this.btnCreateFolder,
            this.btnEdit,
            this.btnDeleteFavorite});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(144, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddFavorite
            // 
            this.btnAddFavorite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFavorite.Image = global::CallJson.Images.AddtoFavorites_16x;
            this.btnAddFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFavorite.Name = "btnAddFavorite";
            this.btnAddFavorite.Size = new System.Drawing.Size(23, 22);
            this.btnAddFavorite.Text = "Add favorite";
            this.btnAddFavorite.Click += new System.EventHandler(this.btnAddFavorite_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCreateFolder.Image = global::CallJson.Images.AddFolder_16x;
            this.btnCreateFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(23, 22);
            this.btnCreateFolder.Text = "Add folder";
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::CallJson.Images.Edit_16x;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "Edit favorite";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteFavorite
            // 
            this.btnDeleteFavorite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteFavorite.Image = global::CallJson.Images.Clearallrequests_8816;
            this.btnDeleteFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteFavorite.Name = "btnDeleteFavorite";
            this.btnDeleteFavorite.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteFavorite.Text = "Delete";
            this.btnDeleteFavorite.Click += new System.EventHandler(this.btnDeleteFavorite_Click);
            // 
            // ControlCallJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ControlCallJson";
            this.Size = new System.Drawing.Size(696, 378);
            this.Load += new System.EventHandler(this.ControlCallJson_Load);
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.btnBar1.ResumeLayout(false);
            this.btnBar1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.stripBody.ResumeLayout(false);
            this.stripBody.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabResults.ResumeLayout(false);
            this.tabResults.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.ComboBox cmboURI;
        private System.Windows.Forms.TextBox txtHeaders;
        private System.Windows.Forms.TextBox txtJsonBody;
        private System.Windows.Forms.ToolStrip btnBar1;
        private System.Windows.Forms.ToolStripButton btnGET;
        private System.Windows.Forms.ToolStripButton btnPOST;
        private System.Windows.Forms.ToolStripButton btnPUT;
        private System.Windows.Forms.ToolStripButton btnDELETE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExec;
        private System.Windows.Forms.ToolStrip stripBody;
        private System.Windows.Forms.ToolStripButton btnOpenBody;
        private System.Windows.Forms.ToolStripButton btnSaveBody;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnOpenHeaders;
        private System.Windows.Forms.ToolStripButton btnSaveHeaders;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnSaveResults;
        private System.Windows.Forms.Label lblNotAvailableGetAndDelete;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvFavorite;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddFavorite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCreateFolder;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDeleteFavorite;
    }
}
