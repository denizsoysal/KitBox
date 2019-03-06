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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_part2));
            this.resume_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlBoxe1 = new V1_KITBOX.UserControlBoxe();
            this.userControlBoxe2 = new V1_KITBOX.UserControlBoxe();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resume_title
            // 
            this.resume_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resume_title.AutoSize = true;
            this.resume_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resume_title.Location = new System.Drawing.Point(434, 0);
            this.resume_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resume_title.Name = "resume_title";
            this.resume_title.Size = new System.Drawing.Size(343, 51);
            this.resume_title.TabIndex = 1;
            this.resume_title.Text = "Personnalisation";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.resume_title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82401F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.17599F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1212, 734);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.userControlBoxe1);
            this.flowLayoutPanel1.Controls.Add(this.userControlBoxe2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1198, 622);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // userControlBoxe1
            // 
            this.userControlBoxe1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlBoxe1.BackgroundImage")));
            this.userControlBoxe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlBoxe1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlBoxe1.Location = new System.Drawing.Point(3, 3);
            this.userControlBoxe1.Name = "userControlBoxe1";
            this.userControlBoxe1.Size = new System.Drawing.Size(620, 329);
            this.userControlBoxe1.TabIndex = 0;
            // 
            // userControlBoxe2
            // 
            this.userControlBoxe2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlBoxe2.BackgroundImage")));
            this.userControlBoxe2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlBoxe2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlBoxe2.Location = new System.Drawing.Point(3, 338);
            this.userControlBoxe2.Name = "userControlBoxe2";
            this.userControlBoxe2.Size = new System.Drawing.Size(620, 302);
            this.userControlBoxe2.TabIndex = 1;
            // 
            // Order_part2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 734);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Order_part2";
            this.Text = "Order_part2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label resume_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControlBoxe userControlBoxe1;
        private UserControlBoxe userControlBoxe2;
    }
}