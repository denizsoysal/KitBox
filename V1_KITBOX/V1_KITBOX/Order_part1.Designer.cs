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
            this.SuspendLayout();
            // 
            // continue_btn
            // 
            this.continue_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.continue_btn.Location = new System.Drawing.Point(572, 638);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(384, 142);
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
            this.comboBoxDepth.Location = new System.Drawing.Point(479, 240);
            this.comboBoxDepth.Name = "comboBoxDepth";
            this.comboBoxDepth.Size = new System.Drawing.Size(202, 33);
            this.comboBoxDepth.TabIndex = 1;
            this.comboBoxDepth.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepth_SelectedIndexChanged);
            // 
            // depth_label
            // 
            this.depth_label.AutoSize = true;
            this.depth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth_label.Location = new System.Drawing.Point(289, 242);
            this.depth_label.Name = "depth_label";
            this.depth_label.Size = new System.Drawing.Size(148, 31);
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
            this.comboBoxWidth.Location = new System.Drawing.Point(479, 387);
            this.comboBoxWidth.Name = "comboBoxWidth";
            this.comboBoxWidth.Size = new System.Drawing.Size(202, 33);
            this.comboBoxWidth.TabIndex = 3;
            this.comboBoxWidth.SelectedIndexChanged += new System.EventHandler(this.comboBoxWidth_SelectedIndexChanged);
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_label.Location = new System.Drawing.Point(289, 389);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(107, 31);
            this.width_label.TabIndex = 4;
            this.width_label.Text = "Largeur";
            // 
            // dimension_title
            // 
            this.dimension_title.AutoSize = true;
            this.dimension_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimension_title.Location = new System.Drawing.Point(495, 66);
            this.dimension_title.Name = "dimension_title";
            this.dimension_title.Size = new System.Drawing.Size(559, 51);
            this.dimension_title.TabIndex = 5;
            this.dimension_title.Text = "Créez votre propre armoire !";
            // 
            // comboBoxHeight
            // 
            this.comboBoxHeight.FormattingEnabled = true;
            this.comboBoxHeight.Items.AddRange(new object[] {
            "100",
            "150",
            "180",
            "200"});
            this.comboBoxHeight.Location = new System.Drawing.Point(479, 523);
            this.comboBoxHeight.Name = "comboBoxHeight";
            this.comboBoxHeight.Size = new System.Drawing.Size(202, 33);
            this.comboBoxHeight.TabIndex = 9;
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_label.Location = new System.Drawing.Point(289, 520);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(111, 31);
            this.height_label.TabIndex = 10;
            this.height_label.Text = "Hauteur";
            // 
            // label_corner_color
            // 
            this.label_corner_color.AutoSize = true;
            this.label_corner_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_corner_color.Location = new System.Drawing.Point(800, 525);
            this.label_corner_color.Name = "label_corner_color";
            this.label_corner_color.Size = new System.Drawing.Size(228, 31);
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
            this.comboBox_corner_color.Location = new System.Drawing.Point(1051, 528);
            this.comboBox_corner_color.Name = "comboBox_corner_color";
            this.comboBox_corner_color.Size = new System.Drawing.Size(200, 33);
            this.comboBox_corner_color.TabIndex = 12;
            this.comboBox_corner_color.SelectedIndexChanged += new System.EventHandler(this.comboBox_corner_color_SelectedIndexChanged);
            // 
            // Order_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 836);
            this.Controls.Add(this.comboBox_corner_color);
            this.Controls.Add(this.label_corner_color);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.comboBoxHeight);
            this.Controls.Add(this.dimension_title);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.comboBoxWidth);
            this.Controls.Add(this.depth_label);
            this.Controls.Add(this.comboBoxDepth);
            this.Controls.Add(this.continue_btn);
            this.Name = "Order_form";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

