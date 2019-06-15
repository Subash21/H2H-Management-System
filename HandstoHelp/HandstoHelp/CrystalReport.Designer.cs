namespace HandstoHelp
{
    partial class CrystalReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrystalReport));
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnmaximize = new System.Windows.Forms.Button();
            this.btnexist = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnminimize
            // 
            this.btnminimize.AutoSize = true;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnminimize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnminimize.Location = new System.Drawing.Point(760, 5);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(32, 35);
            this.btnminimize.TabIndex = 22;
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
            this.btnmaximize.Location = new System.Drawing.Point(798, 4);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(32, 35);
            this.btnmaximize.TabIndex = 23;
            this.btnmaximize.Text = "+";
            this.btnmaximize.UseVisualStyleBackColor = true;
            this.btnmaximize.Click += new System.EventHandler(this.btnmaximize_Click);
            // 
            // btnexist
            // 
            this.btnexist.FlatAppearance.BorderSize = 0;
            this.btnexist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexist.ForeColor = System.Drawing.Color.White;
            this.btnexist.Image = ((System.Drawing.Image)(resources.GetObject("btnexist.Image")));
            this.btnexist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexist.Location = new System.Drawing.Point(836, 4);
            this.btnexist.Name = "btnexist";
            this.btnexist.Size = new System.Drawing.Size(32, 35);
            this.btnexist.TabIndex = 21;
            this.btnexist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexist.UseVisualStyleBackColor = true;
            this.btnexist.Click += new System.EventHandler(this.btnexist_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 60);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(856, 465);
            this.crystalReportViewer1.TabIndex = 24;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Donation Receipt Viewer";
            // 
            // CrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnexist);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnmaximize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrystalReport";
            this.Text = "CrystalReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexist;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnmaximize;
        private System.Windows.Forms.Label label1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}