using System;
using System.Collections.Generic;
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
            // 1-7
            cbx_nbox.Items.Clear();
            switch (this.height)
            {
                case 32:
                    string[] arrayHeight1 = { "1", "2", "3", "4", "5", "6", "7"};
                    cbx_nbox.Items.AddRange(arrayHeight1);
                    break;
                case 42:
                    string[] arrayHeight2 = { "1", "2", "3", "4", "5", "6"};
                    cbx_nbox.Items.AddRange(arrayHeight2);
                    break;
                case 52:
                    string[] arrayHeight3 = { "1", "2", "3", "4", "5"};
                    cbx_nbox.Items.AddRange(arrayHeight3);
                    break;
            }
        }

        public void cbx_nbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nbrBoxes = int.Parse(cbx_nbox.Text);
          /*  //32-52
            cbx_height.Items.Clear();
            switch (this.nbrBoxes)
            {
                case 1 :
                    string[] arrayBox1 = { "32","42","52"};
                    cbx_height.Items.AddRange(arrayBox1);
                    break;
                case 6:
                    string[] arrayBox2 = { "32", "42"};
                    cbx_height.Items.AddRange(arrayBox2);
                    break;
                case 7:
                    string[] arrayBox3 = { "32"};
                    cbx_height.Items.AddRange(arrayBox3);
                    break;
            }*/
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
            for (int i=0; i<this.nbrBoxes; i++)
            {
                cabinets[index_of_cabinet].AddBox(height / nbrBoxes,width,depth,cabinetColor,true,cabinetColor);
                order.AddLastBoxElementsToDico();
            }
            order.AddCornerToDico();                     
            
            MessageBox.Show("Votre armoire a été ajoutée au panier.");
            
        }

        private void UC__Standard_Load(object sender, EventArgs e)
        {
            
            function.Fill("Hauteur", "kitbox_database.`kitbox`", "Reference='Tasseau'", cbx_height);
            function.Fill("Couleur", "kitbox_database.`kitbox`", "Reference='Porte'", cbx_color);
            function.ConnectionClose();

        }
    }
}
