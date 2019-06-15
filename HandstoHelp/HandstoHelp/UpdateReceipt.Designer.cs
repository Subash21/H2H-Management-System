namespace HandstoHelp
{
    partial class UpdateReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateReceipt));
            this.txtdiscreption = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtreceiptno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexist = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnupdatereceipt = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdiscreption
            // 
            this.txtdiscreption.Location = new System.Drawing.Point(244, 321);
            this.txtdiscreption.Multiline = true;
            this.txtdiscreption.Name = "txtdiscreption";
            this.txtdiscreption.Size = new System.Drawing.Size(540, 62);
            this.txtdiscreption.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(23, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 21);
            this.label10.TabIndex = 78;
            this.label10.Text = "Donation Discreption";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(608, 178);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(167, 20);
            this.txtCardNo.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(429, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 21);
            this.label9.TabIndex = 76;
            this.label9.Text = "Donor Email-ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "By CASH",
            "By Cheque",
            "By DD"});
            this.comboBox1.Location = new System.Drawing.Point(608, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(429, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 74;
            this.label8.Text = "Donated In";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(244, 226);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(167, 62);
            this.txtaddress.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(23, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 72;
            this.label7.Text = "Donor Address";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(608, 228);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(167, 20);
            this.txtemail.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(429, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 21);
            this.label6.TabIndex = 70;
            this.label6.Text = "Donor PAN Card No.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(23, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 21);
            this.label5.TabIndex = 68;
            this.label5.Text = "Donation Recived Date :";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(244, 127);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(167, 20);
            this.txtamount.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 66;
            this.label4.Text = "Donation Amount :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(608, 86);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(167, 20);
            this.txtname.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Donation Receipt No.";
            // 
            // txtreceiptno
            // 
            this.txtreceiptno.Location = new System.Drawing.Point(244, 85);
            this.txtreceiptno.Name = "txtreceiptno";
            this.txtreceiptno.Size = new System.Drawing.Size(75, 20);
            this.txtreceiptno.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(429, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 21);
            this.label13.TabIndex = 62;
            this.label13.Text = "Donor Name :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(283, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 61;
            this.label1.Text = "Update Donor Details";
            // 
            // btnexist
            // 
            this.btnexist.FlatAppearance.BorderSize = 0;
            this.btnexist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexist.ForeColor = System.Drawing.Color.White;
            this.btnexist.Image = ((System.Drawing.Image)(resources.GetObject("btnexist.Image")));
            this.btnexist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexist.Location = new System.Drawing.Point(752, 12);
            this.btnexist.Name = "btnexist";
            this.btnexist.Size = new System.Drawing.Size(32, 35);
            this.btnexist.TabIndex = 81;
            this.btnexist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexist.UseVisualStyleBackColor = true;
            this.btnexist.Click += new System.EventHandler(this.btnexist_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMaximize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMaximize.Location = new System.Drawing.Point(714, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(32, 35);
            this.btnMaximize.TabIndex = 82;
            this.btnMaximize.Text = "+";
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnminimize
            // 
            this.btnminimize.AutoSize = true;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnminimize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnminimize.Location = new System.Drawing.Point(676, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(32, 35);
            this.btnminimize.TabIndex = 83;
            this.btnminimize.Text = "__";
            this.btnminimize.UseVisualStyleBackColor = true;
            // 
            // btnupdatereceipt
            // 
            this.btnupdatereceipt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnupdatereceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdatereceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatereceipt.ForeColor = System.Drawing.Color.Maroon;
            this.btnupdatereceipt.Location = new System.Drawing.Point(617, 409);
            this.btnupdatereceipt.Name = "btnupdatereceipt";
            this.btnupdatereceipt.Size = new System.Drawing.Size(167, 29);
            this.btnupdatereceipt.TabIndex = 84;
            this.btnupdatereceipt.Text = "Update Details";
            this.btnupdatereceipt.UseVisualStyleBackColor = true;
            this.btnupdatereceipt.Click += new System.EventHandler(this.btnupdatereceipt_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UpdateReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnupdatereceipt);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnexist);
            this.Controls.Add(this.txtdiscreption);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtreceiptno);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateReceipt";
            this.Text = "UpdateReceipt";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexist;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnupdatereceipt;
        public System.Windows.Forms.TextBox txtdiscreption;
        public System.Windows.Forms.TextBox txtCardNo;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox txtaddress;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txtamount;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtreceiptno;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}