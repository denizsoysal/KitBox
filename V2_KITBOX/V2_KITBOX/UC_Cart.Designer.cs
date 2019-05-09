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
            this.components = new System.ComponentModel.Container();
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
            this.BoxHeigth = new System.Windows.Forms.Label();
            this.CabinetDepth = new System.Windows.Forms.Label();
            this.CabinetWidth = new System.Windows.Forms.Label();
            this.CabinetHeight = new System.Windows.Forms.Label();
            this.CabinetPrice = new System.Windows.Forms.Label();
            this.BoxColor = new System.Windows.Forms.Label();
            this.BoxDoors = new System.Windows.Forms.Label();
            this.CabinetPriceValue = new System.Windows.Forms.Label();
            this.CabinetHeightValue = new System.Windows.Forms.Label();
            this.CabinetWidthValue = new System.Windows.Forms.Label();
            this.CabinetDepthValue = new System.Windows.Forms.Label();
            this.BoxHeigthValue = new System.Windows.Forms.Label();
            this.BoxColorValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CabinetCornerColor = new System.Windows.Forms.Label();
            this.CabinetCornerColorValue = new System.Windows.Forms.Label();
            this.BoxDoorType = new System.Windows.Forms.Label();
            this.BoxDoorColor = new System.Windows.Forms.Label();
            this.BoxDoorTypeValue = new System.Windows.Forms.Label();
            this.BoxDoorColorValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbltest = new System.Windows.Forms.Label();
            this.lbltest2 = new System.Windows.Forms.Label();
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
            this.lbx_cabinets.Location = new System.Drawing.Point(36, 185);
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
            this.lbx_boxes.Location = new System.Drawing.Point(322, 185);
            this.lbx_boxes.Name = "lbx_boxes";
            this.lbx_boxes.Size = new System.Drawing.Size(110, 82);
            this.lbx_boxes.TabIndex = 9;
            this.lbx_boxes.SelectedIndexChanged += new System.EventHandler(this.lbx_boxes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prénom : ";
            // 
            // BoxHeigth
            // 
            this.BoxHeigth.AutoSize = true;
            this.BoxHeigth.Location = new System.Drawing.Point(323, 303);
            this.BoxHeigth.Name = "BoxHeigth";
            this.BoxHeigth.Size = new System.Drawing.Size(54, 13);
            this.BoxHeigth.TabIndex = 20;
            this.BoxHeigth.Text = "Hauteur : ";
            // 
            // CabinetDepth
            // 
            this.CabinetDepth.AutoSize = true;
            this.CabinetDepth.Location = new System.Drawing.Point(37, 397);
            this.CabinetDepth.Name = "CabinetDepth";
            this.CabinetDepth.Size = new System.Drawing.Size(68, 13);
            this.CabinetDepth.TabIndex = 19;
            this.CabinetDepth.Text = "Profondeur : ";
            // 
            // CabinetWidth
            // 
            this.CabinetWidth.AutoSize = true;
            this.CabinetWidth.Location = new System.Drawing.Point(35, 363);
            this.CabinetWidth.Name = "CabinetWidth";
            this.CabinetWidth.Size = new System.Drawing.Size(52, 13);
            this.CabinetWidth.TabIndex = 18;
            this.CabinetWidth.Text = "Largeur : ";
            // 
            // CabinetHeight
            // 
            this.CabinetHeight.AutoSize = true;
            this.CabinetHeight.Location = new System.Drawing.Point(37, 333);
            this.CabinetHeight.Name = "CabinetHeight";
            this.CabinetHeight.Size = new System.Drawing.Size(54, 13);
            this.CabinetHeight.TabIndex = 17;
            this.CabinetHeight.Text = "Hauteur : ";
            // 
            // CabinetPrice
            // 
            this.CabinetPrice.AutoSize = true;
            this.CabinetPrice.Location = new System.Drawing.Point(37, 303);
            this.CabinetPrice.Name = "CabinetPrice";
            this.CabinetPrice.Size = new System.Drawing.Size(33, 13);
            this.CabinetPrice.TabIndex = 16;
            this.CabinetPrice.Text = "Prix : ";
            // 
            // BoxColor
            // 
            this.BoxColor.AutoSize = true;
            this.BoxColor.Location = new System.Drawing.Point(323, 333);
            this.BoxColor.Name = "BoxColor";
            this.BoxColor.Size = new System.Drawing.Size(52, 13);
            this.BoxColor.TabIndex = 21;
            this.BoxColor.Text = "Couleur : ";
            // 
            // BoxDoors
            // 
            this.BoxDoors.AutoSize = true;
            this.BoxDoors.Location = new System.Drawing.Point(323, 363);
            this.BoxDoors.Name = "BoxDoors";
            this.BoxDoors.Size = new System.Drawing.Size(46, 13);
            this.BoxDoors.TabIndex = 22;
            this.BoxDoors.Text = "Portes : ";
            // 
            // CabinetPriceValue
            // 
            this.CabinetPriceValue.AutoSize = true;
            this.CabinetPriceValue.Location = new System.Drawing.Point(76, 303);
            this.CabinetPriceValue.Name = "CabinetPriceValue";
            this.CabinetPriceValue.Size = new System.Drawing.Size(31, 13);
            this.CabinetPriceValue.TabIndex = 23;
            this.CabinetPriceValue.Text = "........";
            // 
            // CabinetHeightValue
            // 
            this.CabinetHeightValue.AutoSize = true;
            this.CabinetHeightValue.Location = new System.Drawing.Point(97, 333);
            this.CabinetHeightValue.Name = "CabinetHeightValue";
            this.CabinetHeightValue.Size = new System.Drawing.Size(31, 13);
            this.CabinetHeightValue.TabIndex = 24;
            this.CabinetHeightValue.Text = "........";
            // 
            // CabinetWidthValue
            // 
            this.CabinetWidthValue.AutoSize = true;
            this.CabinetWidthValue.Location = new System.Drawing.Point(93, 363);
            this.CabinetWidthValue.Name = "CabinetWidthValue";
            this.CabinetWidthValue.Size = new System.Drawing.Size(31, 13);
            this.CabinetWidthValue.TabIndex = 25;
            this.CabinetWidthValue.Text = "........";
            // 
            // CabinetDepthValue
            // 
            this.CabinetDepthValue.AutoSize = true;
            this.CabinetDepthValue.Location = new System.Drawing.Point(111, 397);
            this.CabinetDepthValue.Name = "CabinetDepthValue";
            this.CabinetDepthValue.Size = new System.Drawing.Size(31, 13);
            this.CabinetDepthValue.TabIndex = 26;
            this.CabinetDepthValue.Text = "........";
            // 
            // BoxHeigthValue
            // 
            this.BoxHeigthValue.AutoSize = true;
            this.BoxHeigthValue.Location = new System.Drawing.Point(383, 303);
            this.BoxHeigthValue.Name = "BoxHeigthValue";
            this.BoxHeigthValue.Size = new System.Drawing.Size(31, 13);
            this.BoxHeigthValue.TabIndex = 27;
            this.BoxHeigthValue.Text = "........";
            // 
            // BoxColorValue
            // 
            this.BoxColorValue.AutoSize = true;
            this.BoxColorValue.Location = new System.Drawing.Point(381, 333);
            this.BoxColorValue.Name = "BoxColorValue";
            this.BoxColorValue.Size = new System.Drawing.Size(31, 13);
            this.BoxColorValue.TabIndex = 28;
            this.BoxColorValue.Text = "........";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = " Nom :";
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Location = new System.Drawing.Point(690, 247);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(158, 20);
            this.tbxFirstname.TabIndex = 32;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbxLastname
            // 
            this.tbxLastname.Location = new System.Drawing.Point(690, 284);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(158, 20);
            this.tbxLastname.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(608, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Entrez vos coordonnées :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Vos armoires ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(318, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Etages de l\'armoire";
            // 
            // CabinetCornerColor
            // 
            this.CabinetCornerColor.AutoSize = true;
            this.CabinetCornerColor.Location = new System.Drawing.Point(37, 428);
            this.CabinetCornerColor.Name = "CabinetCornerColor";
            this.CabinetCornerColor.Size = new System.Drawing.Size(60, 13);
            this.CabinetCornerColor.TabIndex = 38;
            this.CabinetCornerColor.Text = "Cornières : ";
            // 
            // CabinetCornerColorValue
            // 
            this.CabinetCornerColorValue.AutoSize = true;
            this.CabinetCornerColorValue.Location = new System.Drawing.Point(103, 428);
            this.CabinetCornerColorValue.Name = "CabinetCornerColorValue";
            this.CabinetCornerColorValue.Size = new System.Drawing.Size(37, 13);
            this.CabinetCornerColorValue.TabIndex = 39;
            this.CabinetCornerColorValue.Text = "..........";
            // 
            // BoxDoorType
            // 
            this.BoxDoorType.AutoSize = true;
            this.BoxDoorType.Location = new System.Drawing.Point(381, 366);
            this.BoxDoorType.Name = "BoxDoorType";
            this.BoxDoorType.Size = new System.Drawing.Size(60, 13);
            this.BoxDoorType.TabIndex = 40;
            this.BoxDoorType.Text = "- Matériau :";
            // 
            // BoxDoorColor
            // 
            this.BoxDoorColor.AutoSize = true;
            this.BoxDoorColor.Location = new System.Drawing.Point(381, 397);
            this.BoxDoorColor.Name = "BoxDoorColor";
            this.BoxDoorColor.Size = new System.Drawing.Size(55, 13);
            this.BoxDoorColor.TabIndex = 41;
            this.BoxDoorColor.Text = "- Couleur :";
            // 
            // BoxDoorTypeValue
            // 
            this.BoxDoorTypeValue.AutoSize = true;
            this.BoxDoorTypeValue.Location = new System.Drawing.Point(447, 366);
            this.BoxDoorTypeValue.Name = "BoxDoorTypeValue";
            this.BoxDoorTypeValue.Size = new System.Drawing.Size(34, 13);
            this.BoxDoorTypeValue.TabIndex = 42;
            this.BoxDoorTypeValue.Text = ".........";
            // 
            // BoxDoorColorValue
            // 
            this.BoxDoorColorValue.AutoSize = true;
            this.BoxDoorColorValue.Location = new System.Drawing.Point(442, 397);
            this.BoxDoorColorValue.Name = "BoxDoorColorValue";
            this.BoxDoorColorValue.Size = new System.Drawing.Size(31, 13);
            this.BoxDoorColorValue.TabIndex = 43;
            this.BoxDoorColorValue.Text = "........";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(768, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(771, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(771, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(771, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(771, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(771, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(771, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(774, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(771, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "label16";
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(644, 77);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(35, 13);
            this.lbltest.TabIndex = 44;
            this.lbltest.Text = "label8";
            // 
            // lbltest2
            // 
            this.lbltest2.AutoSize = true;
            this.lbltest2.Location = new System.Drawing.Point(641, 44);
            this.lbltest2.Name = "lbltest2";
            this.lbltest2.Size = new System.Drawing.Size(35, 13);
            this.lbltest2.TabIndex = 45;
            this.lbltest2.Text = "label8";
            // 
            // UC_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbltest2);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.BoxDoorColorValue);
            this.Controls.Add(this.BoxDoorTypeValue);
            this.Controls.Add(this.BoxDoorColor);
            this.Controls.Add(this.BoxDoorType);
            this.Controls.Add(this.CabinetCornerColorValue);
            this.Controls.Add(this.CabinetCornerColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxLastname);
            this.Controls.Add(this.tbxFirstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxColorValue);
            this.Controls.Add(this.BoxHeigthValue);
            this.Controls.Add(this.CabinetDepthValue);
            this.Controls.Add(this.CabinetWidthValue);
            this.Controls.Add(this.CabinetHeightValue);
            this.Controls.Add(this.CabinetPriceValue);
            this.Controls.Add(this.BoxDoors);
            this.Controls.Add(this.BoxColor);
            this.Controls.Add(this.BoxHeigth);
            this.Controls.Add(this.CabinetDepth);
            this.Controls.Add(this.CabinetWidth);
            this.Controls.Add(this.CabinetHeight);
            this.Controls.Add(this.CabinetPrice);
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
        private System.Windows.Forms.Label BoxHeigth;
        private System.Windows.Forms.Label CabinetDepth;
        private System.Windows.Forms.Label CabinetWidth;
        private System.Windows.Forms.Label CabinetHeight;
        private System.Windows.Forms.Label CabinetPrice;
        private System.Windows.Forms.Label BoxColor;
        private System.Windows.Forms.Label BoxDoors;
        private System.Windows.Forms.Label CabinetPriceValue;
        private System.Windows.Forms.Label CabinetHeightValue;
        private System.Windows.Forms.Label CabinetWidthValue;
        private System.Windows.Forms.Label CabinetDepthValue;
        private System.Windows.Forms.Label BoxHeigthValue;
        private System.Windows.Forms.Label BoxColorValue;
        private System.Windows.Forms.Label BoxDoorsType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CabinetCornerColor;
        private System.Windows.Forms.Label CabinetCornerColorValue;
        private System.Windows.Forms.Label BoxDoorType;
        private System.Windows.Forms.Label BoxDoorColor;
        private System.Windows.Forms.Label BoxDoorTypeValue;
        private System.Windows.Forms.Label BoxDoorColorValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Label lbltest2;
    }
}
