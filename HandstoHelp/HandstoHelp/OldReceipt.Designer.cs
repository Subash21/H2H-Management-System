namespace HandstoHelp
{
    partial class OldReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldReceipt));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btngeneratereceipt = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btndeletereceipt = new System.Windows.Forms.Button();
            this.btnupdatereceipt = new System.Windows.Forms.Button();
            this.btnexist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Old Receipt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 306);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtRno
            // 
            this.txtRno.Location = new System.Drawing.Point(132, 109);
            this.txtRno.Name = "txtRno";
            this.txtRno.Size = new System.Drawing.Size(117, 20);
            this.txtRno.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(26, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "Receipt No.";
            // 
            // btngeneratereceipt
            // 
            this.btngeneratereceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngeneratereceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeneratereceipt.ForeColor = System.Drawing.Color.Maroon;
            this.btngeneratereceipt.Location = new System.Drawing.Point(255, 107);
            this.btngeneratereceipt.Name = "btngeneratereceipt";
            this.btngeneratereceipt.Size = new System.Drawing.Size(164, 23);
            this.btngeneratereceipt.TabIndex = 30;
            this.btngeneratereceipt.Text = "Generate Receipt";
            this.btngeneratereceipt.UseVisualStyleBackColor = true;
            this.btngeneratereceipt.Click += new System.EventHandler(this.btngeneratereceipt_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnexist);
            this.panel4.Controls.Add(this.btnminimize);
            this.panel4.Controls.Add(this.btnMaximize);
            this.panel4.Location = new System.Drawing.Point(636, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 86);
            this.panel4.TabIndex = 31;
            // 
            // btnminimize
            // 
            this.btnminimize.AutoSize = true;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnminimize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnminimize.Location = new System.Drawing.Point(100, 1);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(32, 35);
            this.btnminimize.TabIndex = 19;
            this.btnminimize.Text = "__";
            this.btnminimize.UseVisualStyleBackColor = true;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMaximize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMaximize.Location = new System.Drawing.Point(138, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(32, 35);
            this.btnMaximize.TabIndex = 20;
            this.btnMaximize.Text = "+";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btndeletereceipt
            // 
            this.btndeletereceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndeletereceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletereceipt.ForeColor = System.Drawing.Color.Maroon;
            this.btndeletereceipt.Location = new System.Drawing.Point(636, 107);
            this.btndeletereceipt.Name = "btndeletereceipt";
            this.btndeletereceipt.Size = new System.Drawing.Size(164, 23);
            this.btndeletereceipt.TabIndex = 32;
            this.btndeletereceipt.Text = "Delete Receipt";
            this.btndeletereceipt.UseVisualStyleBackColor = true;
            this.btndeletereceipt.Click += new System.EventHandler(this.btndeletereceipt_Click);
            // 
            // btnupdatereceipt
            // 
            this.btnupdatereceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnupdatereceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdatereceipt.ForeColor = System.Drawing.Color.Maroon;
            this.btnupdatereceipt.Location = new System.Drawing.Point(440, 106);
            this.btnupdatereceipt.Name = "btnupdatereceipt";
            this.btnupdatereceipt.Size = new System.Drawing.Size(164, 23);
            this.btnupdatereceipt.TabIndex = 33;
            this.btnupdatereceipt.Text = "Update Receipt";
            this.btnupdatereceipt.UseVisualStyleBackColor = true;
            this.btnupdatereceipt.Click += new System.EventHandler(this.btnupdatereceipt_Click);
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
            // OldReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 515);
            this.Controls.Add(this.btnupdatereceipt);
            this.Controls.Add(this.btndeletereceipt);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btngeneratereceipt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OldReceipt";
            this.Text = "OldReceipt";
            this.Load += new System.EventHandler(this.OldReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btngeneratereceipt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnexist;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btndeletereceipt;
        private System.Windows.Forms.Button btnupdatereceipt;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}