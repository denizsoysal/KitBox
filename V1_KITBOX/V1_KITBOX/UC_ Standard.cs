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
        private List<string> _cabinet = new List<string>();
        private string depth;
        private string width;
        private string corner_color;

        public UC__Standard()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public UC__Standard(string depth, string width, string corner_color)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.depth = depth;
            this.width = width;
            this.corner_color = corner_color;
            _cabinet.Insert(0, depth);
            _cabinet.Insert(1, width);
            _cabinet.Insert(2, corner_color);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UC_Custom());
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UC_Cart(_cabinet));
        }

        private void buttonOrderP1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UC_OrderP1());
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Introduction());
        }

        private void cbx_height_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._cabinet.Insert(3, cbx_height.Text);               
        }

        private void cbx_nbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._cabinet.Insert(4, cbx_nbox.Text);
        }

        private void cbx_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._cabinet.Insert(5, cbx_color.Text);
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Votre commande a bien été enregistrée");
        }
    }
}
