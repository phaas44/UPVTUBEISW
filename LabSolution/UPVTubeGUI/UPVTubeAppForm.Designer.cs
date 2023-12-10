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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.searchContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentToolStripMenuItem,
            this.reviewToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchContentToolStripMenuItem,
            this.uploadContentToolStripMenuItem});
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.contentToolStripMenuItem.Text = "Content";
            // 
            // reviewToolStripMenuItem
            // 
            this.reviewToolStripMenuItem.Name = "reviewToolStripMenuItem";
            this.reviewToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.reviewToolStripMenuItem.Text = "Review";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutStrip});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // LogoutStrip
            // 
            this.LogoutStrip.Name = "LogoutStrip";
            this.LogoutStrip.Size = new System.Drawing.Size(270, 34);
            this.LogoutStrip.Text = "Logout";
            this.LogoutStrip.Click += new System.EventHandler(this.LogoutStrip_Click);
            // 
            // searchContentToolStripMenuItem
            // 
            this.searchContentToolStripMenuItem.Name = "searchContentToolStripMenuItem";
            this.searchContentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.searchContentToolStripMenuItem.Text = "Search Content";
            // 
            // uploadContentToolStripMenuItem
            // 
            this.uploadContentToolStripMenuItem.Name = "uploadContentToolStripMenuItem";
            this.uploadContentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.uploadContentToolStripMenuItem.Text = "Upload Content";
            this.uploadContentToolStripMenuItem.Click += new System.EventHandler(this.UploadContentStrip_Click);
            // 
            // UPVTubeLoggedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UPVTubeLoggedInForm";
            this.Text = "UPVTubeLoggedInForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}