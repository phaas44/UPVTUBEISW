
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "URI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Upload Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Author\'s nick";
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(35, 42);
            this.TitleText.Multiline = true;
            this.TitleText.Name = "TitleText";
            this.TitleText.ReadOnly = true;
            this.TitleText.Size = new System.Drawing.Size(366, 58);
            this.TitleText.TabIndex = 5;
            this.TitleText.TextChanged += new System.EventHandler(this.TitleText_TextChanged);
            // 
            // NickText
            // 
            this.NickText.Location = new System.Drawing.Point(35, 139);
            this.NickText.Name = "NickText";
            this.NickText.ReadOnly = true;
            this.NickText.Size = new System.Drawing.Size(366, 22);
            this.NickText.TabIndex = 6;
            this.NickText.TextChanged += new System.EventHandler(this.NickText_TextChanged);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(35, 238);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ReadOnly = true;
            this.DescriptionText.Size = new System.Drawing.Size(366, 200);
            this.DescriptionText.TabIndex = 7;
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(35, 487);
            this.DateText.Name = "DateText";
            this.DateText.ReadOnly = true;
            this.DateText.Size = new System.Drawing.Size(366, 22);
            this.DateText.TabIndex = 8;
            // 
            // URIText
            // 
            this.URIText.Location = new System.Drawing.Point(35, 581);
            this.URIText.Name = "URIText";
            this.URIText.ReadOnly = true;
            this.URIText.Size = new System.Drawing.Size(366, 22);
            this.URIText.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Leave a comment!";
            // 
            // CommentText
            // 
            this.CommentText.Location = new System.Drawing.Point(440, 103);
            this.CommentText.Multiline = true;
            this.CommentText.Name = "CommentText";
            this.CommentText.Size = new System.Drawing.Size(366, 183);
            this.CommentText.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DisplayContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 756);
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
    }
}