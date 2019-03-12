namespace V1_KITBOX
{
    partial class UC_Cart
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
            this.labelResume = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPrixTotal = new System.Windows.Forms.Label();
            this.labelDisponibilité = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelResume
            // 
            this.labelResume.AutoSize = true;
            this.labelResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResume.Location = new System.Drawing.Point(24, 40);
            this.labelResume.Name = "labelResume";
            this.labelResume.Size = new System.Drawing.Size(238, 39);
            this.labelResume.TabIndex = 0;
            this.labelResume.Text = "Votre panier :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(31, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 422);
            this.panel1.TabIndex = 1;
            // 
            // labelPrixTotal
            // 
            this.labelPrixTotal.AutoSize = true;
            this.labelPrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixTotal.Location = new System.Drawing.Point(633, 350);
            this.labelPrixTotal.Name = "labelPrixTotal";
            this.labelPrixTotal.Size = new System.Drawing.Size(108, 25);
            this.labelPrixTotal.TabIndex = 2;
            this.labelPrixTotal.Text = "Prix total :";
            // 
            // labelDisponibilité
            // 
            this.labelDisponibilité.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisponibilité.Location = new System.Drawing.Point(600, 393);
            this.labelDisponibilité.Name = "labelDisponibilité";
            this.labelDisponibilité.Size = new System.Drawing.Size(141, 23);
            this.labelDisponibilité.TabIndex = 3;
            this.labelDisponibilité.Text = "Disponibilité :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Continuer les achats";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Valider et payer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(762, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "90€";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(742, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dans une semaine";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDisponibilité);
            this.Controls.Add(this.labelPrixTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelResume);
            this.Name = "UC_Cart";
            this.Size = new System.Drawing.Size(888, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPrixTotal;
        private System.Windows.Forms.Label labelDisponibilité;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
