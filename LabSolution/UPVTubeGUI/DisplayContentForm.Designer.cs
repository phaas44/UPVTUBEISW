
namespace UPVTubeGUI
{
    partial class DisplayContentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.NickText = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.DateText = new System.Windows.Forms.TextBox();
            this.URIText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CommentText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SubscribeButton = new System.Windows.Forms.Button();
            this.UnsunscribeButton = new System.Windows.Forms.Button();
            this.CommentsListView = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 698);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "URI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Upload Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Author\'s nick";
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(39, 52);
            this.TitleText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitleText.Multiline = true;
            this.TitleText.Name = "TitleText";
            this.TitleText.ReadOnly = true;
            this.TitleText.Size = new System.Drawing.Size(411, 72);
            this.TitleText.TabIndex = 5;
            this.TitleText.TextChanged += new System.EventHandler(this.TitleText_TextChanged);
            // 
            // NickText
            // 
            this.NickText.Location = new System.Drawing.Point(39, 174);
            this.NickText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NickText.Name = "NickText";
            this.NickText.ReadOnly = true;
            this.NickText.Size = new System.Drawing.Size(411, 26);
            this.NickText.TabIndex = 6;
            this.NickText.TextChanged += new System.EventHandler(this.NickText_TextChanged);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(39, 298);
            this.DescriptionText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ReadOnly = true;
            this.DescriptionText.Size = new System.Drawing.Size(411, 249);
            this.DescriptionText.TabIndex = 7;
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(39, 609);
            this.DateText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateText.Name = "DateText";
            this.DateText.ReadOnly = true;
            this.DateText.Size = new System.Drawing.Size(411, 26);
            this.DateText.TabIndex = 8;
            // 
            // URIText
            // 
            this.URIText.Location = new System.Drawing.Point(39, 726);
            this.URIText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.URIText.Name = "URIText";
            this.URIText.ReadOnly = true;
            this.URIText.Size = new System.Drawing.Size(411, 26);
            this.URIText.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Leave a comment!";
            // 
            // CommentText
            // 
            this.CommentText.Location = new System.Drawing.Point(495, 129);
            this.CommentText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CommentText.Multiline = true;
            this.CommentText.Name = "CommentText";
            this.CommentText.Size = new System.Drawing.Size(411, 228);
            this.CommentText.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 69);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SubscribeButton
            // 
            this.SubscribeButton.Location = new System.Drawing.Point(40, 207);
            this.SubscribeButton.Name = "SubscribeButton";
            this.SubscribeButton.Size = new System.Drawing.Size(163, 40);
            this.SubscribeButton.TabIndex = 13;
            this.SubscribeButton.Text = "Subscribe";
            this.SubscribeButton.UseVisualStyleBackColor = true;
            this.SubscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
            // 
            // UnsunscribeButton
            // 
            this.UnsunscribeButton.Location = new System.Drawing.Point(231, 207);
            this.UnsunscribeButton.Name = "UnsunscribeButton";
            this.UnsunscribeButton.Size = new System.Drawing.Size(163, 40);
            this.UnsunscribeButton.TabIndex = 15;
            this.UnsunscribeButton.Text = "Unsubscribe";
            this.UnsunscribeButton.UseVisualStyleBackColor = true;
            this.UnsunscribeButton.Click += new System.EventHandler(this.UnsunscribeButton_Click);
            // 
            // CommentsListView
            // 
            this.CommentsListView.FormattingEnabled = true;
            this.CommentsListView.ItemHeight = 20;
            this.CommentsListView.Location = new System.Drawing.Point(495, 525);
            this.CommentsListView.Name = "CommentsListView";
            this.CommentsListView.Size = new System.Drawing.Size(411, 404);
            this.CommentsListView.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Posted comments";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DisplayContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 970);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CommentsListView);
            this.Controls.Add(this.UnsunscribeButton);
            this.Controls.Add(this.SubscribeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CommentText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.URIText);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.NickText);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DisplayContentForm";
            this.Text = "Display Content";
            this.Load += new System.EventHandler(this.DisplayContentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.TextBox NickText;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.TextBox DateText;
        private System.Windows.Forms.TextBox URIText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CommentText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SubscribeButton;
        private System.Windows.Forms.Button UnsunscribeButton;
        private System.Windows.Forms.ListBox CommentsListView;
        private System.Windows.Forms.Label label7;
    }
}