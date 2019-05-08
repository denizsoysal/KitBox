﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1_KITBOX
{
    public partial class UC_OrderP1 : UserControl
    {
        private int depth;
        private int width;
        private string corner_color;
        Order order;
        
        public UC_OrderP1(Order currentOrder)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.order = currentOrder;
        }   
       

            private void continue_btn_Click(object sender, EventArgs e)
        {
            if (comboBoxDepth.Text == "" || comboBoxWidth.Text == "" || comboBox_corner_color.Text == "")
            {
                MessageBox.Show("Veuillez indiquer une valeur pour chaque dimensions ainsi qu'une couleur pour les cornières.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new UC__Standard(order,depth, width, corner_color));
            }
        }


        private void UC_OrderP1_Load(object sender, EventArgs e)
        {
            function.Fill("Profondeur", "kitbox_database.`kitbox`", "Reference='Panneau GD'", comboBoxDepth);
            function.Fill("Largeur", "kitbox_database.`kitbox`", "Profondeur='"+ comboBoxDepth.Text +"' ORDER BY Largeur ASC", comboBoxWidth);
            function.Fill("Couleur", "kitbox_database.`kitbox`", "Reference='Cornieres'", comboBox_corner_color);
            function.ConnectionClose();

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Introduction());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void comboBoxDepth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.depth = int.Parse(comboBoxDepth.Text);
        }

        private void comboBoxWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.width = int.Parse(comboBoxWidth.Text);
        }

        private void comboBox_corner_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.corner_color = comboBox_corner_color.Text;
        }

        
    }
}
