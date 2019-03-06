namespace V1_KITBOX
{
    partial class UserControlBoxe
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
            this.cbx_boxe_height = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_glass = new System.Windows.Forms.CheckBox();
            this.checkBox_wood = new System.Windows.Forms.CheckBox();
            this.boxe_title = new System.Windows.Forms.Label();
            this.Door_color = new System.Windows.Forms.Label();
            this.cbx_door_color = new System.Windows.Forms.ComboBox();
            this.boxe_color = new System.Windows.Forms.Label();
            this.cbx_boxe_color = new System.Windows.Forms.ComboBox();
            this.panel_hiding = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbx_boxe_height
            // 
            this.cbx_boxe_height.FormattingEnabled = true;
            this.cbx_boxe_height.Items.AddRange(new object[] {
            "30",
            "40",
            "50"});
            this.cbx_boxe_height.Location = new System.Drawing.Point(237, 85);
            this.cbx_boxe_height.Name = "cbx_boxe_height";
            this.cbx_boxe_height.Size = new System.Drawing.Size(273, 33);
            this.cbx_boxe_height.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hauteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Portes";
            // 
            // checkBox_glass
            // 
            this.checkBox_glass.AutoSize = true;
            this.checkBox_glass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_glass.Location = new System.Drawing.Point(237, 197);
            this.checkBox_glass.Name = "checkBox_glass";
            this.checkBox_glass.Size = new System.Drawing.Size(112, 35);
            this.checkBox_glass.TabIndex = 3;
            this.checkBox_glass.Text = "Verre";
            this.checkBox_glass.UseVisualStyleBackColor = true;
            this.checkBox_glass.CheckedChanged += new System.EventHandler(this.checkBox_glass_CheckedChanged);
            // 
            // checkBox_wood
            // 
            this.checkBox_wood.AutoSize = true;
            this.checkBox_wood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_wood.Location = new System.Drawing.Point(404, 197);
            this.checkBox_wood.Name = "checkBox_wood";
            this.checkBox_wood.Size = new System.Drawing.Size(99, 35);
            this.checkBox_wood.TabIndex = 4;
            this.checkBox_wood.Text = "Bois";
            this.checkBox_wood.UseVisualStyleBackColor = true;
            this.checkBox_wood.CheckedChanged += new System.EventHandler(this.checkBox_wood_CheckedChanged);
            // 
            // boxe_title
            // 
            this.boxe_title.AutoSize = true;
            this.boxe_title.BackColor = System.Drawing.Color.BurlyWood;
            this.boxe_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxe_title.Location = new System.Drawing.Point(252, 0);
            this.boxe_title.Name = "boxe_title";
            this.boxe_title.Size = new System.Drawing.Size(109, 37);
            this.boxe_title.TabIndex = 5;
            this.boxe_title.Text = "Casier";
            // 
            // Door_color
            // 
            this.Door_color.AutoSize = true;
            this.Door_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Door_color.Location = new System.Drawing.Point(240, 250);
            this.Door_color.Name = "Door_color";
            this.Door_color.Size = new System.Drawing.Size(109, 31);
            this.Door_color.TabIndex = 6;
            this.Door_color.Text = "Couleur";
            // 
            // cbx_door_color
            // 
            this.cbx_door_color.FormattingEnabled = true;
            this.cbx_door_color.Items.AddRange(new object[] {
            "Brun",
            "Blanc"});
            this.cbx_door_color.Location = new System.Drawing.Point(371, 248);
            this.cbx_door_color.Name = "cbx_door_color";
            this.cbx_door_color.Size = new System.Drawing.Size(132, 33);
            this.cbx_door_color.TabIndex = 7;
            // 
            // boxe_color
            // 
            this.boxe_color.AutoSize = true;
            this.boxe_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxe_color.Location = new System.Drawing.Point(66, 143);
            this.boxe_color.Name = "boxe_color";
            this.boxe_color.Size = new System.Drawing.Size(109, 31);
            this.boxe_color.TabIndex = 8;
            this.boxe_color.Text = "Couleur";
            // 
            // cbx_boxe_color
            // 
            this.cbx_boxe_color.FormattingEnabled = true;
            this.cbx_boxe_color.Items.AddRange(new object[] {
            "Brun",
            "Blanc"});
            this.cbx_boxe_color.Location = new System.Drawing.Point(237, 143);
            this.cbx_boxe_color.Name = "cbx_boxe_color";
            this.cbx_boxe_color.Size = new System.Drawing.Size(273, 33);
            this.cbx_boxe_color.TabIndex = 9;
            // 
            // panel_hiding
            // 
            this.panel_hiding.Location = new System.Drawing.Point(113, 238);
            this.panel_hiding.Name = "panel_hiding";
            this.panel_hiding.Size = new System.Drawing.Size(409, 67);
            this.panel_hiding.TabIndex = 10;
            this.panel_hiding.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_hiding_Paint);
            // 
            // UserControlBoxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel_hiding);
            this.Controls.Add(this.cbx_boxe_color);
            this.Controls.Add(this.boxe_color);
            this.Controls.Add(this.cbx_door_color);
            this.Controls.Add(this.Door_color);
            this.Controls.Add(this.boxe_title);
            this.Controls.Add(this.checkBox_wood);
            this.Controls.Add(this.checkBox_glass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_boxe_height);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UserControlBoxe";
            this.Size = new System.Drawing.Size(614, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_boxe_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_glass;
        private System.Windows.Forms.CheckBox checkBox_wood;
        private System.Windows.Forms.Label boxe_title;
        private System.Windows.Forms.Label Door_color;
        private System.Windows.Forms.ComboBox cbx_door_color;
        private System.Windows.Forms.Label boxe_color;
        private System.Windows.Forms.ComboBox cbx_boxe_color;
        private System.Windows.Forms.Panel panel_hiding;
    }
}
