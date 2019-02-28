namespace V1_KITBOX
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
            this.comboBoxHigh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLength = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dimension_title = new System.Windows.Forms.Label();
            this.order_progress = new System.Windows.Forms.ProgressBar();
            this.Equipment = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.color_choice = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.door_color = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(183, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 142);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxHigh
            // 
            this.comboBoxHigh.FormattingEnabled = true;
            this.comboBoxHigh.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBoxHigh.Location = new System.Drawing.Point(368, 235);
            this.comboBoxHigh.Name = "comboBoxHigh";
            this.comboBoxHigh.Size = new System.Drawing.Size(202, 33);
            this.comboBoxHigh.TabIndex = 1;
            this.comboBoxHigh.SelectedIndexChanged += new System.EventHandler(this.comboBoxHigh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Heigh (cm)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxLength
            // 
            this.comboBoxLength.FormattingEnabled = true;
            this.comboBoxLength.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBoxLength.Location = new System.Drawing.Point(368, 355);
            this.comboBoxLength.Name = "comboBoxLength";
            this.comboBoxLength.Size = new System.Drawing.Size(202, 33);
            this.comboBoxLength.TabIndex = 3;
            this.comboBoxLength.SelectedIndexChanged += new System.EventHandler(this.comboBoxHigh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Length (cm)";
            // 
            // dimension_title
            // 
            this.dimension_title.AutoSize = true;
            this.dimension_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimension_title.Location = new System.Drawing.Point(174, 99);
            this.dimension_title.Name = "dimension_title";
            this.dimension_title.Size = new System.Drawing.Size(330, 51);
            this.dimension_title.TabIndex = 5;
            this.dimension_title.Text = "Boxe dimension";
            // 
            // order_progress
            // 
            this.order_progress.Location = new System.Drawing.Point(678, 749);
            this.order_progress.Name = "order_progress";
            this.order_progress.Size = new System.Drawing.Size(726, 60);
            this.order_progress.Step = 25;
            this.order_progress.TabIndex = 6;
            // 
            // Equipment
            // 
            this.Equipment.AutoSize = true;
            this.Equipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipment.Location = new System.Drawing.Point(923, 99);
            this.Equipment.Name = "Equipment";
            this.Equipment.Size = new System.Drawing.Size(229, 51);
            this.Equipment.TabIndex = 7;
            this.Equipment.Text = "Equipment";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(932, 229);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Door";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "White",
            "Black"});
            this.comboBox1.Location = new System.Drawing.Point(368, 441);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // color_choice
            // 
            this.color_choice.AutoSize = true;
            this.color_choice.Location = new System.Drawing.Point(178, 449);
            this.color_choice.Name = "color_choice";
            this.color_choice.Size = new System.Drawing.Size(63, 25);
            this.color_choice.TabIndex = 10;
            this.color_choice.Text = "Color";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Black",
            "White"});
            this.comboBox2.Location = new System.Drawing.Point(1178, 225);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 11;
            // 
            // door_color
            // 
            this.door_color.AutoSize = true;
            this.door_color.Location = new System.Drawing.Point(1089, 229);
            this.door_color.Name = "door_color";
            this.door_color.Size = new System.Drawing.Size(63, 25);
            this.door_color.TabIndex = 12;
            this.door_color.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 836);
            this.Controls.Add(this.door_color);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.color_choice);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Equipment);
            this.Controls.Add(this.order_progress);
            this.Controls.Add(this.dimension_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxHigh);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Order number 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxHigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dimension_title;
        private System.Windows.Forms.ProgressBar order_progress;
        private System.Windows.Forms.Label Equipment;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label color_choice;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label door_color;
    }
}

