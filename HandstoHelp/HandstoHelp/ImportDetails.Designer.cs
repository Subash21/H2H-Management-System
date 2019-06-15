namespace HandstoHelp
{
    partial class ImportDetails
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
            this.label13 = new System.Windows.Forms.Label();
            this.txtbrowser = new System.Windows.Forms.TextBox();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.txtsheetname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnupload = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(164, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Import Membership Details Entry";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(38, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "Please Enter Sheet Name : ";
            // 
            // txtbrowser
            // 
            this.txtbrowser.Location = new System.Drawing.Point(248, 91);
            this.txtbrowser.Name = "txtbrowser";
            this.txtbrowser.Size = new System.Drawing.Size(381, 20);
            this.txtbrowser.TabIndex = 30;
            // 
            // btnbrowser
            // 
            this.btnbrowser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnbrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrowser.ForeColor = System.Drawing.Color.Maroon;
            this.btnbrowser.Location = new System.Drawing.Point(652, 93);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(70, 23);
            this.btnbrowser.TabIndex = 31;
            this.btnbrowser.Text = "Browse";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // txtsheetname
            // 
            this.txtsheetname.Location = new System.Drawing.Point(248, 128);
            this.txtsheetname.Name = "txtsheetname";
            this.txtsheetname.Size = new System.Drawing.Size(209, 20);
            this.txtsheetname.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Please Select XLSheet : ";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(17, 165);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(420, 21);
            this.progressBar1.TabIndex = 34;
            // 
            // dgview
            // 
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(17, 207);
            this.dgview.Name = "dgview";
            this.dgview.Size = new System.Drawing.Size(736, 208);
            this.dgview.TabIndex = 35;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Maroon;
            this.btnShow.Location = new System.Drawing.Point(500, 153);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(109, 35);
            this.btnShow.TabIndex = 36;
            this.btnShow.Text = "Show Details";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnupload
            // 
            this.btnupload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnupload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupload.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupload.ForeColor = System.Drawing.Color.Maroon;
            this.btnupload.Location = new System.Drawing.Point(640, 153);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(109, 35);
            this.btnupload.TabIndex = 37;
            this.btnupload.Text = "Upload Details";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // ImportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsheetname);
            this.Controls.Add(this.btnbrowser);
            this.Controls.Add(this.txtbrowser);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Name = "ImportDetails";
            this.Size = new System.Drawing.Size(798, 433);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbrowser;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.TextBox txtsheetname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnupload;
    }
}
