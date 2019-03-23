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
    public partial class UserControlBoxe : UserControl
    {
        public UserControlBoxe()
        {
            InitializeComponent();
        }

        private void checkBox_glass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_wood_CheckedChanged(object sender, EventArgs e)
        {
            panel_hiding.Hide();
        }

        private void panel_hiding_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
