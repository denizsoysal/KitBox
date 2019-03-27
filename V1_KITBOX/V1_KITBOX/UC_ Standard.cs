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
        private int nbrBoxes;
        private string cabinetColor;
        Order order;

        private string corner_color;
        private int width;
        private int depth;

        public UC__Standard(Order currentOrder, int depth , int width, string corner_color)
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
            this.height = int.Parse(cbx_height.Text);             
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

            this.order.AddCabinet(this.depth, this.width, this.corner_color);
            List<Cabinet> cabinets = order.GetCabinet;
            int index_of_cabinet = cabinets.Count - 1;
            for (int i=0; i<this.nbrBoxes; i++)
            {
                cabinets[index_of_cabinet].AddBox(height / nbrBoxes,width,depth,cabinetColor,true,cabinetColor);
                order.AddLastBoxElements();
            }
            

            
             
            
            MessageBox.Show("Votre armoire a été ajoutée au panier.");
            
        }

        private void UC__Standard_Load(object sender, EventArgs e)
        {

        }
    }
}
