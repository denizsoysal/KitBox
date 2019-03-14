﻿namespace V1_KITBOX
{
    partial class UC__Standard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOrderP1 = new System.Windows.Forms.Button();
            this.buttonCustom = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCart = new System.Windows.Forms.Button();
            this.cbx_height = new System.Windows.Forms.ComboBox();
            this.cbx_nbox = new System.Windows.Forms.ComboBox();
            this.lbl_nbox = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.cbx_color = new System.Windows.Forms.ComboBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOrderP1
            // 
            this.buttonOrderP1.AutoSize = true;
            this.buttonOrderP1.BackColor = System.Drawing.Color.LightGray;
            this.buttonOrderP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderP1.Location = new System.Drawing.Point(151, 935);
            this.buttonOrderP1.Margin = new System.Windows.Forms.Padding(6);
            this.buttonOrderP1.Name = "buttonOrderP1";
            this.buttonOrderP1.Size = new System.Drawing.Size(352, 75);
            this.buttonOrderP1.TabIndex = 0;
            this.buttonOrderP1.Text = "Retour";
            this.buttonOrderP1.UseVisualStyleBackColor = false;
            this.buttonOrderP1.Click += new System.EventHandler(this.buttonOrderP1_Click);
            // 
            // buttonCustom
            // 
            this.buttonCustom.AutoSize = true;
            this.buttonCustom.BackColor = System.Drawing.Color.LightGray;
            this.buttonCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustom.Location = new System.Drawing.Point(736, 936);
            this.buttonCustom.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.Size = new System.Drawing.Size(467, 72);
            this.buttonCustom.TabIndex = 1;
            this.buttonCustom.Text = "Créer une armoire sur mesure";
            this.buttonCustom.UseVisualStyleBackColor = false;
            this.buttonCustom.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.AutoSize = true;
            this.buttonQuit.Location = new System.Drawing.Point(0, 0);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(6);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(256, 44);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Vider le panier et quitter";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Armoires standards";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_info);
            this.panel1.Controls.Add(this.lbl_color);
            this.panel1.Controls.Add(this.cbx_color);
            this.panel1.Controls.Add(this.lbl_height);
            this.panel1.Controls.Add(this.lbl_nbox);
            this.panel1.Controls.Add(this.cbx_nbox);
            this.panel1.Controls.Add(this.cbx_height);
            this.panel1.Location = new System.Drawing.Point(300, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 702);
            this.panel1.TabIndex = 4;
            // 
            // buttonCart
            // 
            this.buttonCart.AutoSize = true;
            this.buttonCart.BackColor = System.Drawing.Color.LightGray;
            this.buttonCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCart.Location = new System.Drawing.Point(1411, 935);
            this.buttonCart.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(229, 73);
            this.buttonCart.TabIndex = 5;
            this.buttonCart.Text = "Voir le panier";
            this.buttonCart.UseVisualStyleBackColor = false;
            this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
            // 
            // cbx_height
            // 
            this.cbx_height.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbx_height.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_height.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_height.FormattingEnabled = true;
            this.cbx_height.Items.AddRange(new object[] {
            "100",
            "150",
            "180",
            "200",
            "230"});
            this.cbx_height.Location = new System.Drawing.Point(539, 187);
            this.cbx_height.Name = "cbx_height";
            this.cbx_height.Size = new System.Drawing.Size(247, 33);
            this.cbx_height.TabIndex = 0;
            this.cbx_height.SelectedIndexChanged += new System.EventHandler(this.cbx_height_SelectedIndexChanged);
            // 
            // cbx_nbox
            // 
            this.cbx_nbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_nbox.FormattingEnabled = true;
            this.cbx_nbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbx_nbox.Location = new System.Drawing.Point(539, 347);
            this.cbx_nbox.Name = "cbx_nbox";
            this.cbx_nbox.Size = new System.Drawing.Size(247, 33);
            this.cbx_nbox.TabIndex = 1;
            this.cbx_nbox.SelectedIndexChanged += new System.EventHandler(this.cbx_nbox_SelectedIndexChanged);
            // 
            // lbl_nbox
            // 
            this.lbl_nbox.AutoSize = true;
            this.lbl_nbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nbox.Location = new System.Drawing.Point(202, 347);
            this.lbl_nbox.Name = "lbl_nbox";
            this.lbl_nbox.Size = new System.Drawing.Size(286, 37);
            this.lbl_nbox.TabIndex = 2;
            this.lbl_nbox.Text = "Nombre de casiers";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_height.Location = new System.Drawing.Point(222, 187);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(266, 37);
            this.lbl_height.TabIndex = 3;
            this.lbl_height.Text = "Hauteur standard";
            // 
            // cbx_color
            // 
            this.cbx_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_color.FormattingEnabled = true;
            this.cbx_color.Items.AddRange(new object[] {
            "Blanc",
            "Brun"});
            this.cbx_color.Location = new System.Drawing.Point(539, 495);
            this.cbx_color.Name = "cbx_color";
            this.cbx_color.Size = new System.Drawing.Size(247, 33);
            this.cbx_color.TabIndex = 4;
            this.cbx_color.SelectedIndexChanged += new System.EventHandler(this.cbx_color_SelectedIndexChanged);
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.Location = new System.Drawing.Point(339, 495);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(129, 37);
            this.lbl_color.TabIndex = 5;
            this.lbl_color.Text = "Couleur";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(141, 629);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(938, 25);
            this.lbl_info.TabIndex = 6;
            this.lbl_info.Text = "Si vous souhaitez une armoire personnalisée veuillez cliquez sur \"Créer une armoi" +
    "re sur mesure\"";
            // 
            // UC__Standard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.buttonCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonCustom);
            this.Controls.Add(this.buttonOrderP1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC__Standard";
            this.Size = new System.Drawing.Size(1776, 1065);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOrderP1;
        private System.Windows.Forms.Button buttonCustom;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCart;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.ComboBox cbx_color;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_nbox;
        private System.Windows.Forms.ComboBox cbx_nbox;
        private System.Windows.Forms.ComboBox cbx_height;
    }
}
