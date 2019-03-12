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
        public UC_Cart()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Cart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UC_OrderP1());
        }

        private void buttonValidateAndPay_Click(object sender, EventArgs e)
        {

        }
    }
}
