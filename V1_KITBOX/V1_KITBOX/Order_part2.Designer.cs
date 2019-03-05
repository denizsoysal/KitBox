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
            this.SuspendLayout();
            // 
            // resume_title
            // 
            this.resume_title.AutoSize = true;
            this.resume_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resume_title.Location = new System.Drawing.Point(323, 58);
            this.resume_title.Name = "resume_title";
            this.resume_title.Size = new System.Drawing.Size(512, 51);
            this.resume_title.TabIndex = 1;
            this.resume_title.Text = "Résumé de la commande";
            // 
            // lbx_resume
            // 
            this.lbx_resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_resume.FormattingEnabled = true;
            this.lbx_resume.ItemHeight = 31;
            this.lbx_resume.Location = new System.Drawing.Point(257, 235);
            this.lbx_resume.Name = "lbx_resume";
            this.lbx_resume.Size = new System.Drawing.Size(650, 221);
            this.lbx_resume.TabIndex = 2;
            // 
            // Order_part2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 784);
            this.Controls.Add(this.lbx_resume);
            this.Controls.Add(this.resume_title);
            this.Name = "Order_part2";
            this.Text = "Order_part2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label resume_title;
        public System.Windows.Forms.ListBox lbx_resume;
    }
}