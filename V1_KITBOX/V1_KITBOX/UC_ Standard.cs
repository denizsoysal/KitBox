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
    public partial class UC__Standard : UserControl
    {
        //private List<string> _cabinet = new List<string>();
        private int height;
        private int Totalheight;
        private int nbrBoxes;
        private string cabinetColor;
        Order order;

        private string corner_color;
        private int width;
        private int depth;

        public UC__Standard(Order currentOrder, int depth, int width, string corner_color)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.order = currentOrder;

            this.width = width;
            this.depth = depth;
            this.corner_color = corner_color;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UC_Custom(order, depth, width, corner_color));
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UC_Cart(order));
        }

        private void buttonOrderP1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UC_OrderP1(order));
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Introduction());
        }




        private void cbx_height_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_nbox.Items.Clear();
            this.height = int.Parse(cbx_height.Text);  // in the case if we want to use the height of a box           
            string[] arrayBox1 = { "1" };
            string[] arrayBox2 = { "2" };
            string[] arrayBox3 = { "3" };
            string[] arrayBox4 = { "4" };
            string[] arrayBox5 = { "5" };
            string[] arrayBox6 = { "6" };
            string[] arrayBox7 = { "7" };
            switch (cbx_height.Text)
            {

                case "36":
                    //  lblHauteur.Text = "Hauteur: 32 cm";
                    cbx_nbox.Items.AddRange(arrayBox1);
                    break;
                case "46 ":
                    // lblHauteur.Text = "Hauteur: 42 cm";
                    cbx_nbox.Items.AddRange(arrayBox1);
                    break;
                case "56":
                    //  lblHauteur.Text = "Hauteur: 52 cm";
                    cbx_nbox.Items.AddRange(arrayBox1);
                    break;
                case "72":
                    // lblHauteur.Text = "Hauteur: 32 cm";
                    cbx_nbox.Items.AddRange(arrayBox2);
                    break;
                case "92":
                    // lblHauteur.Text = "Hauteur: 42 cm";
                    cbx_nbox.Items.AddRange(arrayBox2);
                    break;
                case "108":
                    //  lblHauteur.Text = "Hauteur: 32 cm";
                    cbx_nbox.Items.AddRange(arrayBox3);
                    break;
                case "112":
                    //   lblHauteur.Text = "Hauteur: 52 cm";
                    cbx_nbox.Items.AddRange(arrayBox2);
                    break;
                case "138":
                    //  lblHauteur.Text = "Hauteur: 42 cm";
                    cbx_nbox.Items.AddRange(arrayBox3);
                    break;
                case "144":
                    //   lblHauteur.Text = "Hauteur: 32 cm";
                    cbx_nbox.Items.AddRange(arrayBox4);
                    break;
                case "168":
                    //  lblHauteur.Text = "Hauteur: 52 cm";
                    cbx_nbox.Items.AddRange(arrayBox3);
                    break;
                case "180":
                    //  lblHauteur.Text = "Hauteur: 32 cm";
                    cbx_nbox.Items.AddRange(arrayBox5);
                    break;
                case "184":
                    //  lblHauteur.Text = "Hauteur: 42 cm";
                    cbx_nbox.Items.AddRange(arrayBox4);
                    break;
                case "216":
                    // lblHauteur.Text = "Hauteur: 32 cm";
                    cbx_nbox.Items.AddRange(arrayBox6);
                    break;
                case "224":
                    //   lblHauteur.Text = "Hauteur: 52 cm";
                    cbx_nbox.Items.AddRange(arrayBox4);
                    break;
                case "230":
                    //  lblHauteur.Text = "Hauteur: 42 cm";
                    cbx_nbox.Items.AddRange(arrayBox5);
                    break;
                case "252":
                    //  lblHauteur.Text = "Hauteur: 32 cm";
                    cbx_nbox.Items.AddRange(arrayBox7);
                    break;
                case "276":
                    //   lblHauteur.Text = "Hauteur: 42 cm";
                    cbx_nbox.Items.AddRange(arrayBox6);
                    break;
                case "280":
                    //  lblHauteur.Text = "Hauteur: 52 cm";
                    cbx_nbox.Items.AddRange(arrayBox5);
                    break;
            }
        }


        private void cbx_nbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nbrBoxes = int.Parse(cbx_nbox.Text);
        }

        private void cbx_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cabinetColor = cbx_color.Text;
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            // Vérifier que tous les champs sont remplis

            this.order.AddCabinet(this.depth, this.width, this.height, this.corner_color);
            List<Cabinet> cabinets = order.GetCabinets;
            int index_of_cabinet = cabinets.Count - 1;
            for (int i = 0; i < this.nbrBoxes; i++)
            {
                cabinets[index_of_cabinet].AddBox(height / nbrBoxes, width, depth, cabinetColor, true, cabinetColor);
                order.AddLastBoxElementsToDico();
            }
            order.AddCornerToDico();

            MessageBox.Show("Votre armoire a été ajoutée au panier.");

        }

        private void UC__Standard_Load(object sender, EventArgs e)
        {
            string[] arrayHauteur = { "36", "46", "56", "72", "92", "108", "112", "138", "144", "168", "180", "184", "216", "224", "230", "252", "276", "280" };
            cbx_height.Items.AddRange(arrayHauteur);
            function.Fill("Couleur", "kitbox_database.`kitbox`", "Reference='Porte'", cbx_color);


            function.ConnectionClose();

        }

        private void lbl_height_Click(object sender, EventArgs e)
        {

        }

        public void boxHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Totalheight = int.Parse(cbx_height.Text); //define the total height

        }
    }
}
