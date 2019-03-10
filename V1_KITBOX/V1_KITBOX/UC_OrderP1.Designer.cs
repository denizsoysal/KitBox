namespace V1_KITBOX
{
    partial class UC_OrderP1
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
            this.label_corner_color = new System.Windows.Forms.Label();
            this.dimension_title = new System.Windows.Forms.Label();
            this.continue_btn = new System.Windows.Forms.Button();
            this.comboBox_corner_color = new System.Windows.Forms.ComboBox();
            this.width_label = new System.Windows.Forms.Label();
            this.comboBoxWidth = new System.Windows.Forms.ComboBox();
            this.depth_label = new System.Windows.Forms.Label();
            this.comboBoxDepth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_corner_color
            // 
            this.label_corner_color.AutoSize = true;
            this.label_corner_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_corner_color.Location = new System.Drawing.Point(704, 459);
            this.label_corner_color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_corner_color.Name = "label_corner_color";
            this.label_corner_color.Size = new System.Drawing.Size(228, 31);
            this.label_corner_color.TabIndex = 19;
            this.label_corner_color.Text = "Couleur cornières";
            // 
            // dimension_title
            // 
            this.dimension_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dimension_title.AutoSize = true;
            this.dimension_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimension_title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dimension_title.Location = new System.Drawing.Point(607, 21);
            this.dimension_title.Margin = new System.Windows.Forms.Padding(0);
            this.dimension_title.Name = "dimension_title";
            this.dimension_title.Size = new System.Drawing.Size(559, 51);
            this.dimension_title.TabIndex = 18;
            this.dimension_title.Text = "Créez votre propre armoire !";
            this.dimension_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dimension_title.UseWaitCursor = true;
            // 
            // continue_btn
            // 
            this.continue_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.continue_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.continue_btn.Location = new System.Drawing.Point(710, 836);
            this.continue_btn.Margin = new System.Windows.Forms.Padding(4);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(384, 142);
            this.continue_btn.TabIndex = 13;
            this.continue_btn.Text = "Continuer";
            this.continue_btn.UseVisualStyleBackColor = false;
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // comboBox_corner_color
            // 
            this.comboBox_corner_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_corner_color.FormattingEnabled = true;
            this.comboBox_corner_color.Items.AddRange(new object[] {
            "Blanc",
            "Brun",
            "Noir",
            "Galvanisé"});
            this.comboBox_corner_color.Location = new System.Drawing.Point(978, 457);
            this.comboBox_corner_color.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_corner_color.Name = "comboBox_corner_color";
            this.comboBox_corner_color.Size = new System.Drawing.Size(202, 33);
            this.comboBox_corner_color.TabIndex = 20;
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_label.Location = new System.Drawing.Point(828, 367);
            this.width_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(107, 31);
            this.width_label.TabIndex = 17;
            this.width_label.Text = "Largeur";
            // 
            // comboBoxWidth
            // 
            this.comboBoxWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWidth.FormattingEnabled = true;
            this.comboBoxWidth.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBoxWidth.Location = new System.Drawing.Point(978, 365);
            this.comboBoxWidth.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxWidth.Name = "comboBoxWidth";
            this.comboBoxWidth.Size = new System.Drawing.Size(202, 33);
            this.comboBoxWidth.TabIndex = 16;
            // 
            // depth_label
            // 
            this.depth_label.AutoSize = true;
            this.depth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth_label.Location = new System.Drawing.Point(786, 299);
            this.depth_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depth_label.Name = "depth_label";
            this.depth_label.Size = new System.Drawing.Size(148, 31);
            this.depth_label.TabIndex = 15;
            this.depth_label.Text = "Profondeur";
            // 
            // comboBoxDepth
            // 
            this.comboBoxDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepth.FormattingEnabled = true;
            this.comboBoxDepth.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBoxDepth.Location = new System.Drawing.Point(978, 299);
            this.comboBoxDepth.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDepth.Name = "comboBoxDepth";
            this.comboBoxDepth.Size = new System.Drawing.Size(202, 33);
            this.comboBoxDepth.TabIndex = 14;
            // 
            // UC_OrderP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_corner_color);
            this.Controls.Add(this.dimension_title);
            this.Controls.Add(this.continue_btn);
            this.Controls.Add(this.comboBox_corner_color);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.comboBoxWidth);
            this.Controls.Add(this.depth_label);
            this.Controls.Add(this.comboBoxDepth);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_OrderP1";
            this.Size = new System.Drawing.Size(1777, 1065);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_corner_color;
        private System.Windows.Forms.Label dimension_title;
        private System.Windows.Forms.Button continue_btn;
        private System.Windows.Forms.ComboBox comboBox_corner_color;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.ComboBox comboBoxWidth;
        private System.Windows.Forms.Label depth_label;
        private System.Windows.Forms.ComboBox comboBoxDepth;
    }
}
