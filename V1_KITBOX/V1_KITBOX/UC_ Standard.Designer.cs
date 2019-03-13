namespace V1_KITBOX
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
            this.SuspendLayout();
            // 
            // buttonOrderP1
            // 
            this.buttonOrderP1.AutoSize = true;
            this.buttonOrderP1.BackColor = System.Drawing.Color.LightGray;
            this.buttonOrderP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderP1.Location = new System.Drawing.Point(151, 935);
            this.buttonOrderP1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.buttonCustom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.panel1.Location = new System.Drawing.Point(300, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.buttonCart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(229, 73);
            this.buttonCart.TabIndex = 5;
            this.buttonCart.Text = "Voir le panier";
            this.buttonCart.UseVisualStyleBackColor = false;
            this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC__Standard";
            this.Size = new System.Drawing.Size(1776, 1065);
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
    }
}
