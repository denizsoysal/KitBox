namespace V1_KITBOX
{
    partial class Order_form
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
            this.continue_btn = new System.Windows.Forms.Button();
            this.comboBoxDepth = new System.Windows.Forms.ComboBox();
            this.depth_label = new System.Windows.Forms.Label();
            this.comboBoxWidth = new System.Windows.Forms.ComboBox();
            this.width_label = new System.Windows.Forms.Label();
            this.dimension_title = new System.Windows.Forms.Label();
            this.comboBoxHeight = new System.Windows.Forms.ComboBox();
            this.height_label = new System.Windows.Forms.Label();
            this.label_corner_color = new System.Windows.Forms.Label();
            this.comboBox_corner_color = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // continue_btn
            // 
            this.continue_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.continue_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.continue_btn.Location = new System.Drawing.Point(2, 2);
            this.continue_btn.Margin = new System.Windows.Forms.Padding(2);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(192, 74);
            this.continue_btn.TabIndex = 0;
            this.continue_btn.Text = "Continuer";
            this.continue_btn.UseVisualStyleBackColor = false;
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // comboBoxDepth
            // 
            this.comboBoxDepth.FormattingEnabled = true;
            this.comboBoxDepth.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBoxDepth.Location = new System.Drawing.Point(229, 2);
            this.comboBoxDepth.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDepth.Name = "comboBoxDepth";
            this.comboBoxDepth.Size = new System.Drawing.Size(103, 21);
            this.comboBoxDepth.TabIndex = 1;
            this.comboBoxDepth.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepth_SelectedIndexChanged);
            // 
            // depth_label
            // 
            this.depth_label.AutoSize = true;
            this.depth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth_label.Location = new System.Drawing.Point(146, 0);
            this.depth_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depth_label.Name = "depth_label";
            this.depth_label.Size = new System.Drawing.Size(79, 17);
            this.depth_label.TabIndex = 2;
            this.depth_label.Text = "Profondeur";
            // 
            // comboBoxWidth
            // 
            this.comboBoxWidth.FormattingEnabled = true;
            this.comboBoxWidth.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBoxWidth.Location = new System.Drawing.Point(130, 2);
            this.comboBoxWidth.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWidth.Name = "comboBoxWidth";
            this.comboBoxWidth.Size = new System.Drawing.Size(103, 21);
            this.comboBoxWidth.TabIndex = 3;
            this.comboBoxWidth.SelectedIndexChanged += new System.EventHandler(this.comboBoxWidth_SelectedIndexChanged);
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_label.Location = new System.Drawing.Point(68, 0);
            this.width_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(58, 17);
            this.width_label.TabIndex = 4;
            this.width_label.Text = "Largeur";
            // 
            // dimension_title
            // 
            this.dimension_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dimension_title.AutoSize = true;
            this.dimension_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimension_title.Location = new System.Drawing.Point(0, 0);
            this.dimension_title.Margin = new System.Windows.Forms.Padding(0);
            this.dimension_title.Name = "dimension_title";
            this.dimension_title.Size = new System.Drawing.Size(284, 26);
            this.dimension_title.TabIndex = 5;
            this.dimension_title.Text = "Créez votre propre armoire !";
            this.dimension_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dimension_title.UseWaitCursor = true;
            this.dimension_title.Click += new System.EventHandler(this.dimension_title_Click);
            // 
            // comboBoxHeight
            // 
            this.comboBoxHeight.FormattingEnabled = true;
            this.comboBoxHeight.Items.AddRange(new object[] {
            "100",
            "150",
            "180",
            "200"});
            this.comboBoxHeight.Location = new System.Drawing.Point(229, 2);
            this.comboBoxHeight.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHeight.Name = "comboBoxHeight";
            this.comboBoxHeight.Size = new System.Drawing.Size(103, 21);
            this.comboBoxHeight.TabIndex = 9;
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_label.Location = new System.Drawing.Point(166, 0);
            this.height_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(59, 17);
            this.height_label.TabIndex = 10;
            this.height_label.Text = "Hauteur";
            // 
            // label_corner_color
            // 
            this.label_corner_color.AutoSize = true;
            this.label_corner_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_corner_color.Location = new System.Drawing.Point(7, 0);
            this.label_corner_color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_corner_color.Name = "label_corner_color";
            this.label_corner_color.Size = new System.Drawing.Size(120, 17);
            this.label_corner_color.TabIndex = 11;
            this.label_corner_color.Text = "Couleur cornières";
            // 
            // comboBox_corner_color
            // 
            this.comboBox_corner_color.FormattingEnabled = true;
            this.comboBox_corner_color.Items.AddRange(new object[] {
            "Blanc",
            "Brun",
            "Noir",
            "Galvanisé"});
            this.comboBox_corner_color.Location = new System.Drawing.Point(131, 2);
            this.comboBox_corner_color.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_corner_color.Name = "comboBox_corner_color";
            this.comboBox_corner_color.Size = new System.Drawing.Size(102, 21);
            this.comboBox_corner_color.TabIndex = 12;
            this.comboBox_corner_color.SelectedIndexChanged += new System.EventHandler(this.comboBox_corner_color_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 385);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.comboBoxDepth);
            this.flowLayoutPanel2.Controls.Add(this.depth_label);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 115);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(334, 106);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.comboBoxHeight);
            this.flowLayoutPanel4.Controls.Add(this.height_label);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 227);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(334, 68);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel5, 2);
            this.flowLayoutPanel5.Controls.Add(this.continue_btn);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(482, 304);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(196, 78);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel6.Controls.Add(this.comboBox_corner_color);
            this.flowLayoutPanel6.Controls.Add(this.label_corner_color);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(343, 227);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(235, 68);
            this.flowLayoutPanel6.TabIndex = 5;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel7.Controls.Add(this.comboBoxWidth);
            this.flowLayoutPanel7.Controls.Add(this.width_label);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(343, 115);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(235, 106);
            this.flowLayoutPanel7.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.dimension_title);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(198, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 106);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // Order_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 385);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Order_form";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continue_btn;
        private System.Windows.Forms.ComboBox comboBoxDepth;
        private System.Windows.Forms.Label depth_label;
        private System.Windows.Forms.ComboBox comboBoxWidth;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.Label dimension_title;
        private System.Windows.Forms.ComboBox comboBoxHeight;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.Label label_corner_color;
        private System.Windows.Forms.ComboBox comboBox_corner_color;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

