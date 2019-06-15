namespace HandstoHelp
{
    partial class ViewDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btndonordetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(260, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details of Member";
            // 
            // dgview
            // 
            this.dgview.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.GridColor = System.Drawing.Color.Maroon;
            this.dgview.Location = new System.Drawing.Point(19, 97);
            this.dgview.Name = "dgview";
            this.dgview.Size = new System.Drawing.Size(761, 272);
            this.dgview.TabIndex = 2;
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Maroon;
            this.btnupdate.Location = new System.Drawing.Point(166, 375);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(109, 35);
            this.btnupdate.TabIndex = 33;
            this.btnupdate.Text = "Update Member";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Maroon;
            this.btndelete.Location = new System.Drawing.Point(281, 375);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(109, 35);
            this.btndelete.TabIndex = 34;
            this.btndelete.Text = "Delete Member";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(15, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 21);
            this.label13.TabIndex = 35;
            this.label13.Text = "Search Member : ";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(166, 63);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(158, 20);
            this.txtsearch.TabIndex = 36;
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Maroon;
            this.btnsearch.Location = new System.Drawing.Point(353, 62);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(67, 21);
            this.btnsearch.TabIndex = 37;
            this.btnsearch.Text = "Search ";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnview
            // 
            this.btnview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Maroon;
            this.btnview.Location = new System.Drawing.Point(48, 375);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(109, 35);
            this.btnview.TabIndex = 38;
            this.btnview.Text = "View Member";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btndonordetails
            // 
            this.btndonordetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndonordetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndonordetails.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndonordetails.ForeColor = System.Drawing.Color.Maroon;
            this.btndonordetails.Location = new System.Drawing.Point(396, 375);
            this.btndonordetails.Name = "btndonordetails";
            this.btndonordetails.Size = new System.Drawing.Size(109, 35);
            this.btndonordetails.TabIndex = 39;
            this.btndonordetails.Text = "Donor Details";
            this.btndonordetails.UseVisualStyleBackColor = true;
            this.btndonordetails.Click += new System.EventHandler(this.btndonordetails_Click);
            // 
            // ViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btndonordetails);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "ViewDetails";
            this.Size = new System.Drawing.Size(798, 433);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btndonordetails;
        public System.Windows.Forms.DataGridView dgview;
    }
}
