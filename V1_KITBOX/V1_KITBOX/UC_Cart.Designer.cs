﻿namespace V1_KITBOX
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
            this.lbx_cabinets = new System.Windows.Forms.ListBox();
            this.labelPrixTotal = new System.Windows.Forms.Label();
            this.labelDisponibilité = new System.Windows.Forms.Label();
            this.buttonreturnShopping = new System.Windows.Forms.Button();
            this.buttonValidateAndPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.lbx_boxes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelResume
            // 
            this.labelResume.AutoSize = true;
            this.labelResume.BackColor = System.Drawing.Color.LightGray;
            this.labelResume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResume.Font = new System.Drawing.Font("Calibri", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResume.Location = new System.Drawing.Point(36, 44);
            this.labelResume.Name = "labelResume";
            this.labelResume.Size = new System.Drawing.Size(171, 39);
            this.labelResume.TabIndex = 0;
            this.labelResume.Text = "Votre panier";
            // 
            // lbx_cabinets
            // 
            this.lbx_cabinets.FormattingEnabled = true;
            this.lbx_cabinets.Location = new System.Drawing.Point(36, 125);
            this.lbx_cabinets.Margin = new System.Windows.Forms.Padding(2);
            this.lbx_cabinets.Name = "lbx_cabinets";
            this.lbx_cabinets.Size = new System.Drawing.Size(163, 82);
            this.lbx_cabinets.TabIndex = 0;
            this.lbx_cabinets.SelectedIndexChanged += new System.EventHandler(this.lbx_cabinets_SelectedIndexChanged);
            // 
            // labelPrixTotal
            // 
            this.labelPrixTotal.AutoSize = true;
            this.labelPrixTotal.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixTotal.Location = new System.Drawing.Point(639, 364);
            this.labelPrixTotal.Name = "labelPrixTotal";
            this.labelPrixTotal.Size = new System.Drawing.Size(104, 27);
            this.labelPrixTotal.TabIndex = 2;
            this.labelPrixTotal.Text = "Prix total :";
            // 
            // labelDisponibilité
            // 
            this.labelDisponibilité.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisponibilité.Location = new System.Drawing.Point(606, 407);
            this.labelDisponibilité.Name = "labelDisponibilité";
            this.labelDisponibilité.Size = new System.Drawing.Size(153, 23);
            this.labelDisponibilité.TabIndex = 3;
            this.labelDisponibilité.Text = "Disponibilité :";
            // 
            // buttonreturnShopping
            // 
            this.buttonreturnShopping.Location = new System.Drawing.Point(612, 468);
            this.buttonreturnShopping.Name = "buttonreturnShopping";
            this.buttonreturnShopping.Size = new System.Drawing.Size(132, 49);
            this.buttonreturnShopping.TabIndex = 4;
            this.buttonreturnShopping.Text = "Continuer les achats";
            this.buttonreturnShopping.UseVisualStyleBackColor = true;
            this.buttonreturnShopping.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonValidateAndPay
            // 
            this.buttonValidateAndPay.Location = new System.Drawing.Point(753, 468);
            this.buttonValidateAndPay.Name = "buttonValidateAndPay";
            this.buttonValidateAndPay.Size = new System.Drawing.Size(132, 49);
            this.buttonValidateAndPay.TabIndex = 5;
            this.buttonValidateAndPay.Text = "Valider et payer";
            this.buttonValidateAndPay.UseVisualStyleBackColor = true;
            this.buttonValidateAndPay.Click += new System.EventHandler(this.buttonValidateAndPay_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(768, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "90€";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dans une semaine";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonQuit
            // 
            this.buttonQuit.AutoSize = true;
            this.buttonQuit.Location = new System.Drawing.Point(0, 0);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(128, 23);
            this.buttonQuit.TabIndex = 8;
            this.buttonQuit.Text = "Vider le panier et quitter";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // lbx_boxes
            // 
            this.lbx_boxes.FormattingEnabled = true;
            this.lbx_boxes.Location = new System.Drawing.Point(260, 125);
            this.lbx_boxes.Name = "lbx_boxes";
            this.lbx_boxes.Size = new System.Drawing.Size(110, 82);
            this.lbx_boxes.TabIndex = 9;
            this.lbx_boxes.SelectedIndexChanged += new System.EventHandler(this.lbx_boxes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UC_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbx_boxes);
            this.Controls.Add(this.lbx_cabinets);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonreturnShopping);
            this.Controls.Add(this.labelResume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonValidateAndPay);
            this.Controls.Add(this.labelPrixTotal);
            this.Controls.Add(this.labelDisponibilité);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Cart";
            this.Size = new System.Drawing.Size(888, 554);
            this.Load += new System.EventHandler(this.UC_Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResume;
        private System.Windows.Forms.Label labelPrixTotal;
        private System.Windows.Forms.Label labelDisponibilité;
        private System.Windows.Forms.Button buttonreturnShopping;
        private System.Windows.Forms.Button buttonValidateAndPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.ListBox lbx_cabinets;
        private System.Windows.Forms.ListBox lbx_boxes;
        private System.Windows.Forms.Label label3;
    }
}
