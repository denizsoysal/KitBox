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
    public partial class UC_Cart : UserControl
    {
       // private List<string> cabinet;
        private Order order;
        public UC_Cart(Order currentOrder)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.order = currentOrder;

            for(int i=0; i< this.order.GetCabinets.Count;i++)
            {
                lbx_cabinets.Items.Add("Armoire " +(i+1).ToString() );
            }
            lbx_cabinets.SelectedIndex = 0;
            
            lbx_boxes.SelectedIndex = 0; // this call the changed selected item so we don't need to add the items here
            

            // provisoire, pour visualiser le dico des pièces,
            // montre comment accéder aux codes bares des pièces et leur nombre nécessaire
            /*string result = "";
            foreach (string code in order.getOrderElements.Keys)
            {
                result += code + " : ";
                result += order.getOrderElements[code].ToString() + "\n";
            }
            label3.Text = result;*/
        }

        


        private void UC_Cart_Load(object sender, EventArgs e)
        {
       
        }

        

        private void buttonValidateAndPay_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UC_OrderP1(this.order));
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Introduction());
        }

        private void lbx_cabinets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCabinet = lbx_cabinets.SelectedIndex;
            lbx_boxes.Items.Clear();
            for (int j = 0; j < this.order.GetCabinets[selectedCabinet].GetBoxes.Count; j++)
            {
                lbx_boxes.Items.Add("Etage " + (j + 1).ToString());
            }
            lbx_boxes.SelectedIndex = 0;    // also calls the method ...IndexChanged()

            CabinetHeightValue.Text = order.GetCabinets[selectedCabinet].GetHeight().ToString();
            CabinetDepthValue.Text = order.GetCabinets[selectedCabinet].GetDepth().ToString();
            CabinetWidthValue.Text = order.GetCabinets[selectedCabinet].GetWidth().ToString();
            CabinetCornerColorValue.Text = order.GetCabinets[selectedCabinet].GetCorner().GetColor();
        }

        private void lbx_boxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCabinet = lbx_cabinets.SelectedIndex;
            int selectedBox = lbx_boxes.SelectedIndex;

            BoxHeigthValue.Text = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetHeight.ToString();
            BoxColorValue.Text = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetColor;

            string doorColor = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetDoorColor;
            if(doorColor== null)
            {
                BoxDoorTypeValue.Text = "/";
                BoxDoorColorValue.Text = "/";
            }
            else if (doorColor == "Verre")
            {
                BoxDoorTypeValue.Text = "Verre";
                BoxDoorColorValue.Text = "Transparent";
            }
            else
            {
                BoxDoorTypeValue.Text = "Bois";
                BoxDoorColorValue.Text = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetDoorColor;
            }

            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
