namespace UPVTubeGUI
{
    partial class PendingReviewContentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ContentGrid = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Public = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelatedCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ApproveButton = new System.Windows.Forms.RadioButton();
            this.RejectButton = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contents with pending review:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(602, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 89);
            this.button1.TabIndex = 2;
            this.button1.Text = "Review";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContentGrid
            // 
            this.ContentGrid.AllowUserToAddRows = false;
            this.ContentGrid.AllowUserToDeleteRows = false;
            this.ContentGrid.AllowUserToResizeColumns = false;
            this.ContentGrid.AllowUserToResizeRows = false;
            this.ContentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Nick,
            this.Description,
            this.Public,
            this.UploadDate,
            this.RelatedCourses,
            this.Content});
            this.ContentGrid.Enabled = false;
            this.ContentGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ContentGrid.Location = new System.Drawing.Point(1, 94);
            this.ContentGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContentGrid.MultiSelect = false;
            this.ContentGrid.Name = "ContentGrid";
            this.ContentGrid.ReadOnly = true;
            this.ContentGrid.RowHeadersWidth = 51;
            this.ContentGrid.RowTemplate.Height = 24;
            this.ContentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContentGrid.Size = new System.Drawing.Size(1154, 279);
            this.ContentGrid.TabIndex = 3;
            this.ContentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Nick
            // 
            this.Nick.HeaderText = "Nick";
            this.Nick.MinimumWidth = 6;
            this.Nick.Name = "Nick";
            this.Nick.ReadOnly = true;
            this.Nick.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // Public
            // 
            this.Public.HeaderText = "Public";
            this.Public.MinimumWidth = 6;
            this.Public.Name = "Public";
            this.Public.ReadOnly = true;
            this.Public.Width = 125;
            // 
            // UploadDate
            // 
            this.UploadDate.HeaderText = "Upload Date";
            this.UploadDate.MinimumWidth = 6;
            this.UploadDate.Name = "UploadDate";
            this.UploadDate.ReadOnly = true;
            this.UploadDate.Width = 125;
            // 
            // RelatedCourses
            // 
            this.RelatedCourses.HeaderText = "Related Courses";
            this.RelatedCourses.MinimumWidth = 6;
            this.RelatedCourses.Name = "RelatedCourses";
            this.RelatedCourses.ReadOnly = true;
            this.RelatedCourses.Width = 125;
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1233, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 246);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ApproveButton
            // 
            this.ApproveButton.AutoSize = true;
            this.ApproveButton.Location = new System.Drawing.Point(1253, 61);
            this.ApproveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(93, 24);
            this.ApproveButton.TabIndex = 5;
            this.ApproveButton.TabStop = true;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RejectButton
            // 
            this.RejectButton.AutoSize = true;
            this.RejectButton.Location = new System.Drawing.Point(1402, 61);
            this.RejectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(80, 24);
            this.RejectButton.TabIndex = 6;
            this.RejectButton.TabStop = true;
            this.RejectButton.Text = "Reject";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1307, 402);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 72);
            this.button2.TabIndex = 7;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 380);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 65);
            this.button3.TabIndex = 8;
            this.button3.Text = "Show detailed information";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PendingReviewContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 611);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ContentGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PendingReviewContentForm";
            this.Text = "Review pending content";
            ((System.ComponentModel.ISupportInitialize)(this.ContentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ContentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Public;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelatedCourses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton ApproveButton;
        private System.Windows.Forms.RadioButton RejectButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.Button button3;
    }
}