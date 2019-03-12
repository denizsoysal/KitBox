using System;
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
        public Cabinet armoire;
        public UC_OrderP1()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

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

                this.armoire = new Cabinet(depth, width, comboBox_corner_color.Text);

                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new UC__Standard());
                

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_OrderP1_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Introduction());
        }
    }
}
