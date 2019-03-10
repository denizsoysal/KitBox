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
    public partial class UC_OrderP2 : UserControl
        
    {
        public int BoxIndex;
        public UC_OrderP2()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void UC_OrderP2_Load(object sender, EventArgs e)
        {
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            

            if (button.Text == "")
            {
                switch (button.Name)
                {
                    case "button2":
                        panel2.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
                        button2.Text = "2";
                        button3.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        break;
                    case "button3":
                        panel3.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
                        button3.Text = "3";
                        button4.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        break;
                    case "button4":
                        panel4.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
                        button4.Text = "4";
                        button5.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;

                        break;
                    case "button5":
                        panel5.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
                        button5.Text = "5";
                        button6.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;

                        break;
                    case "button6":
                        panel6.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
                        button7.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        button6.Text = "6";
                        break;
                    case "button7":
                        panel7.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
                        button7.Text = "7";
                        break;
                }
            }
            
            button.BackgroundImage = global::V1_KITBOX.Properties.Resources.rond_button;
            lbl_etage.Text = "Etage " + button.Text;
            BoxIndex = Int32.Parse(button.Text);



        }
    }
}
