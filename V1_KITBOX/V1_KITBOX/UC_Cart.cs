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
        }

        /*public UC_Cart(List<string> cabinet)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.cabinet = cabinet;
            lbx_commande.Items.Insert(1, "\tHauteur(cm): " + cabinet[3]);
            lbx_commande.Items.Insert(2, "\tNombre de casiers: " + cabinet[4]);
            lbx_commande.Items.Insert(3, "\tCouleur: " + cabinet[5]);
            lbx_commande.Items.Insert(4, "\tCouleur cornières: " + cabinet[2]);
            lbx_commande.Items.Insert(2, "\tProfondeur(cm): " + cabinet[0]);
            lbx_commande.Items.Insert(3, "\tLargeur(cm): " + cabinet[1]);

        }*/


        private void UC_Cart_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
           // this.Controls.Add(new UC_OrderP1());
        }

        private void buttonValidateAndPay_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Introduction());
        }
    }
}
