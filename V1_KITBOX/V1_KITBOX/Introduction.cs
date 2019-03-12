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
    public partial class Introduction : UserControl
    {
        public Introduction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UC_OrderP1());
        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }
    }
}
