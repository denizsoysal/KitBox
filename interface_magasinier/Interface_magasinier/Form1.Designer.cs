namespace WinForms_MySQL
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.REF = new System.Windows.Forms.TextBox();
            this.CodeBarre = new System.Windows.Forms.TextBox();
            this.Hauteur = new System.Windows.Forms.TextBox();
            this.Profondeur = new System.Windows.Forms.TextBox();
            this.Largeur = new System.Windows.Forms.TextBox();
            this.Couleur = new System.Windows.Forms.TextBox();
            this.EnStock = new System.Windows.Forms.TextBox();
            this.StockMinimum = new System.Windows.Forms.TextBox();
            this.Dimensions = new System.Windows.Forms.TextBox();
            this.PrixClient = new System.Windows.Forms.TextBox();
            this.NbPecesCasier = new System.Windows.Forms.TextBox();
            this.PrixFourn1 = new System.Windows.Forms.TextBox();
            this.DelaiFourn1 = new System.Windows.Forms.TextBox();
            this.PrixFourn2 = new System.Windows.Forms.TextBox();
            this.DelaiFourn2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add to database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // REF
            // 
            this.REF.Location = new System.Drawing.Point(104, 27);
            this.REF.Name = "REF";
            this.REF.Size = new System.Drawing.Size(100, 20);
            this.REF.TabIndex = 2;
            // 
            // CodeBarre
            // 
            this.CodeBarre.Location = new System.Drawing.Point(104, 70);
            this.CodeBarre.Name = "CodeBarre";
            this.CodeBarre.Size = new System.Drawing.Size(100, 20);
            this.CodeBarre.TabIndex = 3;
            // 
            // Hauteur
            // 
            this.Hauteur.Location = new System.Drawing.Point(104, 160);
            this.Hauteur.Name = "Hauteur";
            this.Hauteur.Size = new System.Drawing.Size(100, 20);
            this.Hauteur.TabIndex = 4;
            // 
            // Profondeur
            // 
            this.Profondeur.Location = new System.Drawing.Point(104, 205);
            this.Profondeur.Name = "Profondeur";
            this.Profondeur.Size = new System.Drawing.Size(100, 20);
            this.Profondeur.TabIndex = 5;
            // 
            // Largeur
            // 
            this.Largeur.Location = new System.Drawing.Point(104, 254);
            this.Largeur.Name = "Largeur";
            this.Largeur.Size = new System.Drawing.Size(100, 20);
            this.Largeur.TabIndex = 6;
            this.Largeur.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Couleur
            // 
            this.Couleur.Location = new System.Drawing.Point(104, 295);
            this.Couleur.Name = "Couleur";
            this.Couleur.Size = new System.Drawing.Size(100, 20);
            this.Couleur.TabIndex = 7;
            // 
            // EnStock
            // 
            this.EnStock.Location = new System.Drawing.Point(104, 344);
            this.EnStock.Name = "EnStock";
            this.EnStock.Size = new System.Drawing.Size(100, 20);
            this.EnStock.TabIndex = 8;
            // 
            // StockMinimum
            // 
            this.StockMinimum.Location = new System.Drawing.Point(322, 27);
            this.StockMinimum.Name = "StockMinimum";
            this.StockMinimum.Size = new System.Drawing.Size(100, 20);
            this.StockMinimum.TabIndex = 9;
            // 
            // Dimensions
            // 
            this.Dimensions.Location = new System.Drawing.Point(104, 116);
            this.Dimensions.Name = "Dimensions";
            this.Dimensions.Size = new System.Drawing.Size(100, 20);
            this.Dimensions.TabIndex = 10;
            // 
            // PrixClient
            // 
            this.PrixClient.Location = new System.Drawing.Point(322, 70);
            this.PrixClient.Name = "PrixClient";
            this.PrixClient.Size = new System.Drawing.Size(100, 20);
            this.PrixClient.TabIndex = 11;
            // 
            // NbPecesCasier
            // 
            this.NbPecesCasier.Location = new System.Drawing.Point(322, 116);
            this.NbPecesCasier.Name = "NbPecesCasier";
            this.NbPecesCasier.Size = new System.Drawing.Size(100, 20);
            this.NbPecesCasier.TabIndex = 12;
            // 
            // PrixFourn1
            // 
            this.PrixFourn1.Location = new System.Drawing.Point(322, 160);
            this.PrixFourn1.Name = "PrixFourn1";
            this.PrixFourn1.Size = new System.Drawing.Size(100, 20);
            this.PrixFourn1.TabIndex = 13;
            // 
            // DelaiFourn1
            // 
            this.DelaiFourn1.Location = new System.Drawing.Point(322, 209);
            this.DelaiFourn1.Name = "DelaiFourn1";
            this.DelaiFourn1.Size = new System.Drawing.Size(100, 20);
            this.DelaiFourn1.TabIndex = 14;
            // 
            // PrixFourn2
            // 
            this.PrixFourn2.Location = new System.Drawing.Point(322, 254);
            this.PrixFourn2.Name = "PrixFourn2";
            this.PrixFourn2.Size = new System.Drawing.Size(100, 20);
            this.PrixFourn2.TabIndex = 15;
            // 
            // DelaiFourn2
            // 
            this.DelaiFourn2.Location = new System.Drawing.Point(322, 295);
            this.DelaiFourn2.Name = "DelaiFourn2";
            this.DelaiFourn2.Size = new System.Drawing.Size(100, 20);
            this.DelaiFourn2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "REF :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "CodeBarre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Dimensions :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Profondeur :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "EnStock :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "StockMinimum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "PrixFourn1 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "DelaiFourn1 :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "DelaiFourn2 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Hauteur :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Largeur :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Couleur";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "PrixClient :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(233, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "NbPiecesCasier :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(259, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "PrixFourn2 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DelaiFourn2);
            this.groupBox1.Controls.Add(this.PrixFourn2);
            this.groupBox1.Controls.Add(this.DelaiFourn1);
            this.groupBox1.Controls.Add(this.PrixFourn1);
            this.groupBox1.Controls.Add(this.NbPecesCasier);
            this.groupBox1.Controls.Add(this.PrixClient);
            this.groupBox1.Controls.Add(this.Dimensions);
            this.groupBox1.Controls.Add(this.StockMinimum);
            this.groupBox1.Controls.Add(this.EnStock);
            this.groupBox1.Controls.Add(this.Couleur);
            this.groupBox1.Controls.Add(this.Largeur);
            this.groupBox1.Controls.Add(this.Profondeur);
            this.groupBox1.Controls.Add(this.Hauteur);
            this.groupBox1.Controls.Add(this.CodeBarre);
            this.groupBox1.Controls.Add(this.REF);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 393);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data of the item";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "New item";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox REF;
        private System.Windows.Forms.TextBox CodeBarre;
        private System.Windows.Forms.TextBox Hauteur;
        private System.Windows.Forms.TextBox Profondeur;
        private System.Windows.Forms.TextBox Largeur;
        private System.Windows.Forms.TextBox Couleur;
        private System.Windows.Forms.TextBox EnStock;
        private System.Windows.Forms.TextBox StockMinimum;
        private System.Windows.Forms.TextBox Dimensions;
        private System.Windows.Forms.TextBox PrixClient;
        private System.Windows.Forms.TextBox NbPecesCasier;
        private System.Windows.Forms.TextBox PrixFourn1;
        private System.Windows.Forms.TextBox DelaiFourn1;
        private System.Windows.Forms.TextBox PrixFourn2;
        private System.Windows.Forms.TextBox DelaiFourn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}