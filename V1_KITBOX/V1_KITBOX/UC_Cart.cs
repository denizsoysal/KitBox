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

            for(int i=0; i< this.order.GetCabinet.Count;i++)
            {
                lbx_cabinets.Items.Add("Armoire " +(i+1).ToString() );
            }
            lbx_cabinets.SelectedIndex = 0;
            
            lbx_boxes.SelectedIndex = 0; // this call the changed selected item so we don't need to add the items here
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
            for (int j = 0; j < this.order.GetCabinet[selectedCabinet].getboxes.Count; j++)
            {
                lbx_boxes.Items.Add("Etage " + (j + 1).ToString());
            }
            lbx_boxes.SelectedIndex = 0;
        }

        private void lbx_boxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
