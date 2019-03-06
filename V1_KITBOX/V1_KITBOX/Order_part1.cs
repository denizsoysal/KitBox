using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1_KITBOX
{
    public partial class Order_form : Form
    {
        public Cabinet armoire;
        public Order_form()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Creating a new cabinet when continue_btn is clicked
        private void continue_btn_Click(object sender, EventArgs e)
        {
            if (comboBoxDepth.Text == "" || comboBoxWidth.Text == "" || comboBox_corner_color.Text == "")
            {
                MessageBox.Show("Veuillez indiquer une valeur pour chaque dimensions ainsi qu'une couleur pour les cornières.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Convert data from comboBox to int
            else
            {
                int depth = int.Parse(comboBoxDepth.Items[comboBoxDepth.SelectedIndex].ToString());
                int width = int.Parse(comboBoxWidth.Items[comboBoxWidth.SelectedIndex].ToString());
                // int height = int.Parse(comboBoxHeight.Items[comboBoxHeight.SelectedIndex].ToString());

                this.armoire = new Cabinet(depth, width, 0, comboBox_corner_color.Text);
                Order_part2 resume_order = new Order_part2();

                // Show resume of order on listBox of second form (Order_part2)
                // resume_order.lbx_resume.Items.Add("Profondeur: " + armoire.GetDepth() + " cm ");
                // resume_order.lbx_resume.Items.Add("Largeur: " + armoire.GetWidth() + " cm ");
                // resume_order.lbx_resume.Items.Add("Hauteur: " + armoire.GetHeight() + " cm ");
                // resume_order.lbx_resume.Items.Add("Couleur cornières: " + armoire.GetCornerColor());
                resume_order.Show();
                Hide();

            }
            
        }

        private void comboBoxDepth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxWidth.Items.Contains("10"))
            {
                comboBoxWidth.Items.Insert(0, "10");
            }

            if (comboBoxDepth.Text == "10")
            {
                comboBoxWidth.Items.Remove("10");
                // comboBoxWidth.Items.Remove();

            }
        }

        private void comboBoxWidth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_corner_color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dimension_title_Click(object sender, EventArgs e)
        {

        }
    }
}
