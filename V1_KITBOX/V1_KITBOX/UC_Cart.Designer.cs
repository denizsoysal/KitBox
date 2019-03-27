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
            this.lbx_cabinets = new System.Windows.Forms.ListBox();
            this.labelPrixTotal = new System.Windows.Forms.Label();
            this.labelDisponibilité = new System.Windows.Forms.Label();
            this.buttonreturnShopping = new System.Windows.Forms.Button();
            this.buttonValidateAndPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.lbx_boxes = new System.Windows.Forms.ListBox();
            this.label_codeRef = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelResume
            // 
            this.labelResume.AutoSize = true;
            this.labelResume.BackColor = System.Drawing.Color.LightGray;
            this.labelResume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResume.Font = new System.Drawing.Font("Calibri", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResume.Location = new System.Drawing.Point(72, 85);
            this.labelResume.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelResume.Name = "labelResume";
            this.labelResume.Size = new System.Drawing.Size(330, 74);
            this.labelResume.TabIndex = 0;
            this.labelResume.Text = "Votre panier";
            // 
            // lbx_cabinets
            // 
            this.lbx_cabinets.FormattingEnabled = true;
            this.lbx_cabinets.ItemHeight = 25;
            this.lbx_cabinets.Location = new System.Drawing.Point(72, 240);
            this.lbx_cabinets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbx_cabinets.Name = "lbx_cabinets";
            this.lbx_cabinets.Size = new System.Drawing.Size(322, 154);
            this.lbx_cabinets.TabIndex = 0;
            this.lbx_cabinets.SelectedIndexChanged += new System.EventHandler(this.lbx_cabinets_SelectedIndexChanged);
            // 
            // labelPrixTotal
            // 
            this.labelPrixTotal.AutoSize = true;
            this.labelPrixTotal.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixTotal.Location = new System.Drawing.Point(1278, 700);
            this.labelPrixTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPrixTotal.Name = "labelPrixTotal";
            this.labelPrixTotal.Size = new System.Drawing.Size(202, 53);
            this.labelPrixTotal.TabIndex = 2;
            this.labelPrixTotal.Text = "Prix total :";
            // 
            // labelDisponibilité
            // 
            this.labelDisponibilité.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisponibilité.Location = new System.Drawing.Point(1212, 783);
            this.labelDisponibilité.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDisponibilité.Name = "labelDisponibilité";
            this.labelDisponibilité.Size = new System.Drawing.Size(306, 44);
            this.labelDisponibilité.TabIndex = 3;
            this.labelDisponibilité.Text = "Disponibilité :";
            // 
            // buttonreturnShopping
            // 
            this.buttonreturnShopping.Location = new System.Drawing.Point(1224, 900);
            this.buttonreturnShopping.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonreturnShopping.Name = "buttonreturnShopping";
            this.buttonreturnShopping.Size = new System.Drawing.Size(264, 94);
            this.buttonreturnShopping.TabIndex = 4;
            this.buttonreturnShopping.Text = "Continuer les achats";
            this.buttonreturnShopping.UseVisualStyleBackColor = true;
            this.buttonreturnShopping.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonValidateAndPay
            // 
            this.buttonValidateAndPay.Location = new System.Drawing.Point(1506, 900);
            this.buttonValidateAndPay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonValidateAndPay.Name = "buttonValidateAndPay";
            this.buttonValidateAndPay.Size = new System.Drawing.Size(264, 94);
            this.buttonValidateAndPay.TabIndex = 5;
            this.buttonValidateAndPay.Text = "Valider et payer";
            this.buttonValidateAndPay.UseVisualStyleBackColor = true;
            this.buttonValidateAndPay.Click += new System.EventHandler(this.buttonValidateAndPay_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1536, 704);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "90€";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1496, 787);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dans une semaine";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonQuit
            // 
            this.buttonQuit.AutoSize = true;
            this.buttonQuit.Location = new System.Drawing.Point(0, 0);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(256, 44);
            this.buttonQuit.TabIndex = 8;
            this.buttonQuit.Text = "Vider le panier et quitter";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // lbx_boxes
            // 
            this.lbx_boxes.FormattingEnabled = true;
            this.lbx_boxes.ItemHeight = 25;
            this.lbx_boxes.Location = new System.Drawing.Point(520, 240);
            this.lbx_boxes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbx_boxes.Name = "lbx_boxes";
            this.lbx_boxes.Size = new System.Drawing.Size(216, 154);
            this.lbx_boxes.TabIndex = 9;
            this.lbx_boxes.SelectedIndexChanged += new System.EventHandler(this.lbx_boxes_SelectedIndexChanged);
            // 
            // label_codeRef
            // 
            this.label_codeRef.AutoSize = true;
            this.label_codeRef.Location = new System.Drawing.Point(72, 487);
            this.label_codeRef.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_codeRef.Name = "label_codeRef";
            this.label_codeRef.Size = new System.Drawing.Size(70, 25);
            this.label_codeRef.TabIndex = 10;
            this.label_codeRef.Text = "label3";
            this.label_codeRef.Click += new System.EventHandler(this.label3_Click);
            // 
            // UC_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.label_codeRef);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Cart";
            this.Size = new System.Drawing.Size(1776, 1065);
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
        private System.Windows.Forms.Label label_codeRef;
    }
}
