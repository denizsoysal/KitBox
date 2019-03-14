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
   
    public partial class UC_Custom : UserControl
        
    {
        private int BoxIndex;
      
        
        
        
        public UC_Custom()
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
                        panel2.Show();
                        button2.Text = "2";
                        button3.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        button3.Show();
                        btn_delete2.Show();
                        

                        break;
                    case "button3":
                        panel3.Show();
                        button3.Text = "3";
                        button4.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        button4.Show();
                        btn_delete3.Show();
                        btn_delete2.Hide();

                        break;
                    case "button4":
                        panel4.Show();
                        button4.Text = "4";
                        button5.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        button5.Show();
                        btn_delete4.Show();
                        btn_delete3.Hide();


                        break;
                    case "button5":
                        panel5.Show();
                        button5.Text = "5";
                        button6.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        button6.Show();
                        btn_delete5.Show();
                        btn_delete4.Hide();


                        break;
                    case "button6":
                        panel6.Show();
                        button6.Text = "6";
                        button7.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                        button7.Show();
                        btn_delete6.Show();
                        btn_delete5.Hide();

                        break;
                    case "button7":
                        panel7.Show();
                        button7.Text = "7";
                        btn_delete7.Show();
                        btn_delete6.Hide();

                        break;
                }
            }
            
            button.BackgroundImage = global::V1_KITBOX.Properties.Resources.rond_button;
            lbl_etage.Text = "Etage " + button.Text;
            this.BoxIndex = Int32.Parse(button.Text) - 1;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch(button.Name)
            {
                case "btn_delete7":
                    button7.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button7.Text = "";
                    panel7.Hide();
                    btn_delete6.Show();
                    break;
                case "btn_delete6":
                    button6.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button6.Text = "";
                    panel6.Hide();
                    button7.Hide();
                    btn_delete5.Show();
                    break;
                case "btn_delete5":
                    button5.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button5.Text = "";   
                    panel5.Hide();
                    button6.Hide();
                    btn_delete4.Show();
                    break;
                case "btn_delete4":
                    button4.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button4.Text = "";
                    button5.Hide();
                    panel4.Hide();
                    btn_delete3.Show();
                    break;
                case "btn_delete3":
                    button3.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button3.Text = "";
                    button4.Hide();
                    panel3.Hide();
                    btn_delete2.Show();
                    break;
                case "btn_delete2":
                    button2.BackgroundImage = global::V1_KITBOX.Properties.Resources.add_button;
                    button2.Text = "";
                    button3.Hide();
                    panel2.Hide();
                    break;
            }
            button.Hide();
         
        }

        private void buttonAdToCart_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UC_Cart());
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Introduction());
        }

        private void cbx_height_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
