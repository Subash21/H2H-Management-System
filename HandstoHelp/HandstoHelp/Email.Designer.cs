namespace HandstoHelp
{
    partial class Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnexist = new System.Windows.Forms.Button();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnmaximize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonoremail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemailsubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemailbody = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtattachmentpath = new System.Windows.Forms.TextBox();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbsmtp = new System.Windows.Forms.ComboBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnexist);
            this.panel4.Controls.Add(this.btnminimize);
            this.panel4.Controls.Add(this.btnmaximize);
            this.panel4.Location = new System.Drawing.Point(576, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 75);
            this.panel4.TabIndex = 22;
            // 
            // btnexist
            // 
            this.btnexist.FlatAppearance.BorderSize = 0;
            this.btnexist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexist.ForeColor = System.Drawing.Color.White;
            this.btnexist.Image = ((System.Drawing.Image)(resources.GetObject("btnexist.Image")));
            this.btnexist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexist.Location = new System.Drawing.Point(165, 3);
            this.btnexist.Name = "btnexist";
            this.btnexist.Size = new System.Drawing.Size(32, 35);
            this.btnexist.TabIndex = 6;
            this.btnexist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexist.UseVisualStyleBackColor = true;
            this.btnexist.Click += new System.EventHandler(this.btnexist_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.AutoSize = true;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnminimize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnminimize.Location = new System.Drawing.Point(111, 3);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(32, 35);
            this.btnminimize.TabIndex = 19;
            this.btnminimize.Text = "__";
            this.btnminimize.UseVisualStyleBackColor = true;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnmaximize
            // 
            this.btnmaximize.FlatAppearance.BorderSize = 0;
            this.btnmaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmaximize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnmaximize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnmaximize.Location = new System.Drawing.Point(138, 3);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(32, 35);
            this.btnmaximize.TabIndex = 20;
            this.btnmaximize.Text = "+";
            this.btnmaximize.UseVisualStyleBackColor = true;
            this.btnmaximize.Click += new System.EventHandler(this.btnmaximize_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(245, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Email Details";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Your Email_ID  :";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(190, 86);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(249, 20);
            this.txtemail.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Your Password  :";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(190, 118);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(249, 20);
            this.txtpassword.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(23, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Donor Email_ID  :";
            // 
            // txtDonoremail
            // 
            this.txtDonoremail.Location = new System.Drawing.Point(190, 153);
            this.txtDonoremail.Name = "txtDonoremail";
            this.txtDonoremail.Size = new System.Drawing.Size(249, 20);
            this.txtDonoremail.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(23, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 46;
            this.label5.Text = "SMTP  :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(23, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "Email Subject  :";
            // 
            // txtemailsubject
            // 
            this.txtemailsubject.Location = new System.Drawing.Point(190, 218);
            this.txtemailsubject.Name = "txtemailsubject";
            this.txtemailsubject.Size = new System.Drawing.Size(414, 20);
            this.txtemailsubject.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(23, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 50;
            this.label7.Text = "Email Body  :";
            // 
            // txtemailbody
            // 
            this.txtemailbody.Location = new System.Drawing.Point(190, 261);
            this.txtemailbody.Multiline = true;
            this.txtemailbody.Name = "txtemailbody";
            this.txtemailbody.Size = new System.Drawing.Size(414, 102);
            this.txtemailbody.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(30, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 52;
            this.label8.Text = "Attachment :";
            // 
            // txtattachmentpath
            // 
            this.txtattachmentpath.Location = new System.Drawing.Point(190, 385);
            this.txtattachmentpath.Name = "txtattachmentpath";
            this.txtattachmentpath.Size = new System.Drawing.Size(414, 20);
            this.txtattachmentpath.TabIndex = 53;
            // 
            // btnbrowser
            // 
            this.btnbrowser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnbrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrowser.ForeColor = System.Drawing.Color.Maroon;
            this.btnbrowser.Location = new System.Drawing.Point(190, 415);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(70, 23);
            this.btnbrowser.TabIndex = 54;
            this.btnbrowser.Text = "Browse";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Maroon;
            this.btnSend.Location = new System.Drawing.Point(637, 360);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(109, 60);
            this.btnSend.TabIndex = 55;
            this.btnSend.Text = "Send Mail";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbsmtp
            // 
            this.cbsmtp.FormattingEnabled = true;
            this.cbsmtp.Items.AddRange(new object[] {
            "smtp.gmail.com",
            "smtp.outlook.com",
            "smtp.yahoo.com"});
            this.cbsmtp.Location = new System.Drawing.Point(190, 186);
            this.cbsmtp.Name = "cbsmtp";
            this.cbsmtp.Size = new System.Drawing.Size(249, 21);
            this.cbsmtp.TabIndex = 56;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.cbsmtp);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnbrowser);
            this.Controls.Add(this.txtattachmentpath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtemailbody);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtemailsubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDonoremail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Email";
            this.Text = "Email";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnexist;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnmaximize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonoremail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemailsubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtemailbody;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtattachmentpath;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbsmtp;
        public System.Windows.Forms.TextBox txtemail;
    }
}