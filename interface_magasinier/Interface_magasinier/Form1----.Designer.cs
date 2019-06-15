namespace WinForms_MySQL
{
    partial class frmWM
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWM));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.tbxTemperature = new System.Windows.Forms.TextBox();
            this.tbxHumidity = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbxChoose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(379, 36);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveDate);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(379, 77);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
//            this.btnLoad.Click += new System.EventHandler(this.LoadData);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(12, 45);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(67, 13);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "Temperature";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(15, 77);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(47, 13);
            this.lblHumidity.TabIndex = 3;
            this.lblHumidity.Text = "Humidity";
            // 
            // tbxTemperature
            // 
            this.tbxTemperature.Location = new System.Drawing.Point(170, 36);
            this.tbxTemperature.Name = "tbxTemperature";
            this.tbxTemperature.Size = new System.Drawing.Size(100, 20);
            this.tbxTemperature.TabIndex = 4;
            this.tbxTemperature.Text = "Temperature";
            // 
            // tbxHumidity
            // 
            this.tbxHumidity.Location = new System.Drawing.Point(170, 68);
            this.tbxHumidity.Name = "tbxHumidity";
            this.tbxHumidity.Size = new System.Drawing.Size(100, 20);
            this.tbxHumidity.TabIndex = 5;
            this.tbxHumidity.Text = "Humidity";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // cbxChoose
            // 
            this.cbxChoose.FormattingEnabled = true;
            this.cbxChoose.Location = new System.Drawing.Point(170, 128);
            this.cbxChoose.Name = "cbxChoose";
            this.cbxChoose.Size = new System.Drawing.Size(121, 21);
            this.cbxChoose.TabIndex = 7;
            // 
            // frmWM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 257);
            this.Controls.Add(this.cbxChoose);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tbxHumidity);
            this.Controls.Add(this.tbxTemperature);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWM";
            this.Text = "WinForms MySQL";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.TextBox tbxTemperature;
        private System.Windows.Forms.TextBox tbxHumidity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbxChoose;
    }
}

