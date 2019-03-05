namespace V1_KITBOX
{
    partial class Order_part2
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
            this.resume_title = new System.Windows.Forms.Label();
            this.lbx_resume = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resume_title
            // 
            this.resume_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resume_title.AutoSize = true;
            this.resume_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resume_title.Location = new System.Drawing.Point(167, 0);
            this.resume_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resume_title.Name = "resume_title";
            this.resume_title.Size = new System.Drawing.Size(262, 26);
            this.resume_title.TabIndex = 1;
            this.resume_title.Text = "Résumé de la commande";
            // 
            // lbx_resume
            // 
            this.lbx_resume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbx_resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_resume.FormattingEnabled = true;
            this.lbx_resume.ItemHeight = 16;
            this.lbx_resume.Location = new System.Drawing.Point(135, 76);
            this.lbx_resume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbx_resume.Name = "lbx_resume";
            this.lbx_resume.Size = new System.Drawing.Size(327, 116);
            this.lbx_resume.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbx_resume, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.resume_title, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.42257F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.57743F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 381);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Order_part2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order_part2";
            this.Text = "Order_part2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label resume_title;
        public System.Windows.Forms.ListBox lbx_resume;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}