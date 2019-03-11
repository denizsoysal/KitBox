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
        private int BoxIndex;
        
        
        
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
                        btn_delete2.Show();

                        break;
                    case "button3":
                        panel3.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
                        button3.Text = "3";
                        button4.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        btn_delete3.Show();
                        btn_delete2.Hide();

                        break;
                    case "button4":
                        panel4.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
                        button4.Text = "4";
                        button5.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        btn_delete4.Show();
                        btn_delete3.Hide();


                        break;
                    case "button5":
                        panel5.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
                        button5.Text = "5";
                        button6.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        btn_delete5.Show();
                        btn_delete4.Hide();


                        break;
                    case "button6":
                        panel6.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
                        button7.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        button6.Text = "6";
                        btn_delete6.Show();
                        btn_delete5.Hide();

                        break;
                    case "button7":
                        panel7.BackgroundImage = global::V1_KITBOX.Properties.Resources.etage_boxe;
                        button7.Text = "7";
                        btn_delete7.Show();
                        btn_delete6.Hide();

                        break;
                }
            }
            
            button.BackgroundImage = global::V1_KITBOX.Properties.Resources.rond_button;
            lbl_etage.Text = "Etage " + button.Text;
            this.BoxIndex = Int32.Parse(button.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch(button.Name)
            {
                case "btn_delete7":
                    panel7.BackgroundImage = null;
                    button7.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button7.Text = "";
                    btn_delete6.Show();
                    break;
                case "btn_delete6":
                    panel6.BackgroundImage = null;
                    button6.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button6.Text = "";
                    button7.BackgroundImage = null;
                    btn_delete5.Show();
                    break;
                case "btn_delete5":
                    panel5.BackgroundImage = null;
                    button5.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button5.Text = "";
                    button6.BackgroundImage = null;
                    btn_delete4.Show();
                    break;
                case "btn_delete4":
                    panel4.BackgroundImage = null;
                    button4.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button4.Text = "";
                    button5.BackgroundImage = null;
                    btn_delete3.Show();
                    break;
                case "btn_delete3":
                    panel3.BackgroundImage = null;
                    button3.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button3.Text = "";
                    button4.BackgroundImage = null;
                    btn_delete2.Show();
                    break;
                case "btn_delete2":
                    panel2.BackgroundImage = null;
                    button2.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button2.Text = "";
                    button3.BackgroundImage = null;
                    break;
            }
            button.Hide();
         
        }
    }
}
