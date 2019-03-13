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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_OrderP1));
            this.label_corner_color = new System.Windows.Forms.Label();
            this.dimension_title = new System.Windows.Forms.Label();
            this.continue_btn = new System.Windows.Forms.Button();
            this.comboBox_corner_color = new System.Windows.Forms.ComboBox();
            this.width_label = new System.Windows.Forms.Label();
            this.comboBoxWidth = new System.Windows.Forms.ComboBox();
            this.depth_label = new System.Windows.Forms.Label();
            this.comboBoxDepth = new System.Windows.Forms.ComboBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_corner_color
            // 
            this.label_corner_color.AutoSize = true;
            this.label_corner_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_corner_color.Location = new System.Drawing.Point(90, 529);
            this.label_corner_color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_corner_color.Name = "label_corner_color";
            this.label_corner_color.Size = new System.Drawing.Size(228, 31);
            this.label_corner_color.TabIndex = 19;
            this.label_corner_color.Text = "Couleur cornières";
            // 
            // dimension_title
            // 
            this.dimension_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dimension_title.BackColor = System.Drawing.Color.LightGray;
            this.dimension_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dimension_title.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimension_title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dimension_title.Location = new System.Drawing.Point(34, 100);
            this.dimension_title.Margin = new System.Windows.Forms.Padding(0);
            this.dimension_title.Name = "dimension_title";
            this.dimension_title.Size = new System.Drawing.Size(638, 167);
            this.dimension_title.TabIndex = 18;
            this.dimension_title.Text = "Choisissez les caractéristiques principales de votre armoire";
            this.dimension_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dimension_title.UseWaitCursor = true;
            // 
            // continue_btn
            // 
            this.continue_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.continue_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.continue_btn.Location = new System.Drawing.Point(186, 785);
            this.continue_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.comboBox_corner_color.Location = new System.Drawing.Point(364, 527);
            this.comboBox_corner_color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_corner_color.Name = "comboBox_corner_color";
            this.comboBox_corner_color.Size = new System.Drawing.Size(202, 33);
            this.comboBox_corner_color.TabIndex = 20;
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_label.Location = new System.Drawing.Point(214, 437);
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
            this.comboBoxWidth.Location = new System.Drawing.Point(364, 435);
            this.comboBoxWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxWidth.Name = "comboBoxWidth";
            this.comboBoxWidth.Size = new System.Drawing.Size(202, 33);
            this.comboBoxWidth.TabIndex = 16;
            // 
            // depth_label
            // 
            this.depth_label.AutoSize = true;
            this.depth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth_label.Location = new System.Drawing.Point(172, 367);
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
            this.comboBoxDepth.Location = new System.Drawing.Point(364, 367);
            this.comboBoxDepth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDepth.Name = "comboBoxDepth";
            this.comboBoxDepth.Size = new System.Drawing.Size(202, 33);
            this.comboBoxDepth.TabIndex = 14;
            // 
            // buttonQuit
            // 
            this.buttonQuit.AutoSize = true;
            this.buttonQuit.Location = new System.Drawing.Point(0, 0);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(256, 44);
            this.buttonQuit.TabIndex = 22;
            this.buttonQuit.Text = "Vider le panier et quitter";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(716, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 875);
            this.panel1.TabIndex = 21;
            // 
            // UC_OrderP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_corner_color);
            this.Controls.Add(this.dimension_title);
            this.Controls.Add(this.continue_btn);
            this.Controls.Add(this.comboBox_corner_color);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.comboBoxWidth);
            this.Controls.Add(this.depth_label);
            this.Controls.Add(this.comboBoxDepth);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_OrderP1";
            this.Size = new System.Drawing.Size(1776, 1065);
            this.Load += new System.EventHandler(this.UC_OrderP1_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQuit;
    }
}
