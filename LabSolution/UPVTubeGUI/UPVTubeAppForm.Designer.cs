namespace UPVTubeGUI
{
    partial class UPVTubeAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPendingContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TextLabel = new System.Windows.Forms.Label();
            this.subscriptionsdataGridView = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newcontentbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcontentbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentToolStripMenuItem,
            this.reviewToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchContentToolStripMenuItem,
            this.uploadContentToolStripMenuItem});
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.contentToolStripMenuItem.Text = "Content";
            // 
            // searchContentToolStripMenuItem
            // 
            this.searchContentToolStripMenuItem.Name = "searchContentToolStripMenuItem";
            this.searchContentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.searchContentToolStripMenuItem.Text = "Search Content";
            this.searchContentToolStripMenuItem.Click += new System.EventHandler(this.searchContentToolStripMenuItem_Click);
            // 
            // uploadContentToolStripMenuItem
            // 
            this.uploadContentToolStripMenuItem.Name = "uploadContentToolStripMenuItem";
            this.uploadContentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.uploadContentToolStripMenuItem.Text = "Upload Content";
            this.uploadContentToolStripMenuItem.Click += new System.EventHandler(this.UploadContentStrip_Click);
            // 
            // reviewToolStripMenuItem
            // 
            this.reviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPendingContentToolStripMenuItem});
            this.reviewToolStripMenuItem.Name = "reviewToolStripMenuItem";
            this.reviewToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.reviewToolStripMenuItem.Text = "Review";
            // 
            // viewPendingContentToolStripMenuItem
            // 
            this.viewPendingContentToolStripMenuItem.Name = "viewPendingContentToolStripMenuItem";
            this.viewPendingContentToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.viewPendingContentToolStripMenuItem.Text = "View Pending Content";
            this.viewPendingContentToolStripMenuItem.Click += new System.EventHandler(this.ViewPendingContentStrip_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutStrip});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // LogoutStrip
            // 
            this.LogoutStrip.Name = "LogoutStrip";
            this.LogoutStrip.Size = new System.Drawing.Size(270, 34);
            this.LogoutStrip.Text = "Logout";
            this.LogoutStrip.Click += new System.EventHandler(this.LogoutStrip_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(21, 53);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(289, 20);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Latest contents of subscribed members";
            this.TextLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // subscriptionsdataGridView
            // 
            this.subscriptionsdataGridView.AllowUserToAddRows = false;
            this.subscriptionsdataGridView.AllowUserToDeleteRows = false;
            this.subscriptionsdataGridView.AutoGenerateColumns = false;
            this.subscriptionsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subscriptionsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.URI,
            this.Description,
            this.UploadDate,
            this.Owner});
            this.subscriptionsdataGridView.DataSource = this.newcontentbindingSource;
            this.subscriptionsdataGridView.Location = new System.Drawing.Point(25, 88);
            this.subscriptionsdataGridView.Name = "subscriptionsdataGridView";
            this.subscriptionsdataGridView.ReadOnly = true;
            this.subscriptionsdataGridView.RowHeadersWidth = 62;
            this.subscriptionsdataGridView.RowTemplate.Height = 28;
            this.subscriptionsdataGridView.Size = new System.Drawing.Size(756, 327);
            this.subscriptionsdataGridView.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "ds_Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // URI
            // 
            this.URI.DataPropertyName = "ds_URI";
            this.URI.HeaderText = "URI";
            this.URI.MinimumWidth = 8;
            this.URI.Name = "URI";
            this.URI.ReadOnly = true;
            this.URI.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "ds_Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // UploadDate
            // 
            this.UploadDate.DataPropertyName = "ds_UploadDate";
            this.UploadDate.HeaderText = "Upload Date";
            this.UploadDate.MinimumWidth = 8;
            this.UploadDate.Name = "UploadDate";
            this.UploadDate.ReadOnly = true;
            this.UploadDate.Width = 150;
            // 
            // Owner
            // 
            this.Owner.DataPropertyName = "ds_Owner";
            this.Owner.HeaderText = "Creator";
            this.Owner.MinimumWidth = 8;
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            this.Owner.Width = 150;
            // 
            // UPVTubeAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subscriptionsdataGridView);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UPVTubeAppForm";
            this.Text = "UPVTubeLoggedInForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UPVTubeAppForm_FormClosing);
            this.Load += new System.EventHandler(this.UPVTubeAppForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcontentbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutStrip;
        private System.Windows.Forms.ToolStripMenuItem searchContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPendingContentToolStripMenuItem;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.DataGridView subscriptionsdataGridView;
        private System.Windows.Forms.BindingSource newcontentbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn URI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
    }
}