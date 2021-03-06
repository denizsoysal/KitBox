﻿using System;
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
        private int BoxIndex = 0;
        private List<int> heights;
        private List<string> colors;
        private List<bool> doors;
        private List<string> doors_color;

        private string corner_color;
        private int width;
        private int depth;

        private Order order;
      
        
        
        
        public UC_Custom(Order currentOrder, int depth , int width, string corner_color)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.order = currentOrder;

            this.width = width;
            this.depth = depth;
            this.corner_color = corner_color;

            this.heights = new List<int>();
            this.colors = new List<string>();
        
            this.colors.Add("");
            this.heights.Add(0);

            this.doors = new List<bool>();
            this.doors_color = new List<string>();

            this.doors.Add(false);
            this.doors_color.Add(null);        

        }
        private void UC_OrderP2_Load(object sender, EventArgs e)
        {
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // This box is not visible yet
            if (button.Text == "")
            {

                this.colors.Add("");
                this.heights.Add(0);
                this.doors.Add(false);
                this.doors_color.Add(null);
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

            cbx_color.SelectedValue = null;
            cbx_color.SelectedText = null;
            cbx_color.Text = null;

            cbx_height.SelectedValue = null;
            cbx_height.SelectedText = null;
            cbx_height.Text = null;



            cbx_color.SelectedValue = colors.ElementAt(BoxIndex);
            cbx_color.SelectedText = colors.ElementAt(BoxIndex);
            cbx_color.Text = colors.ElementAt(BoxIndex);

            cbx_height.SelectedValue = heights.ElementAt(BoxIndex).ToString();
            cbx_height.SelectedText = heights.ElementAt(BoxIndex).ToString();
            cbx_height.Text = heights.ElementAt(BoxIndex).ToString();

            if (doors_color[BoxIndex] == "Verre")
            {
                checkBox_glass.Checked = true;
            }
            else if (doors_color[BoxIndex] != "Verre" & doors_color[BoxIndex] != null)
            {
                checkBox_wood.Checked = true;
                cbx_door_color.Text = doors_color[BoxIndex];
            }
            else
            {
                checkBox_wood.Checked = false;
                checkBox_glass.Checked = false;
                cbx_door_color.Text = "";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.colors.RemoveAt(colors.Count - 1);
            this.heights.RemoveAt(heights.Count - 1);
            doors.RemoveAt(doors.Count - 1);
            doors_color.RemoveAt(doors_color.Count - 1);
            if (BoxIndex > (heights.Count-1) )
            {
                BoxIndex = heights.Count - 1;
                lbl_etage.Text = "Etage " + (BoxIndex+1).ToString();

                cbx_color.SelectedValue = null;
                cbx_color.SelectedText = null;
                cbx_color.Text = null;

                cbx_height.SelectedValue = null;
                cbx_height.SelectedText = null;
                cbx_height.Text = null;
                
                cbx_color.SelectedValue = colors.ElementAt(BoxIndex);
                cbx_color.SelectedText = colors.ElementAt(BoxIndex);
                cbx_color.Text = colors.ElementAt(BoxIndex);

                cbx_height.SelectedValue = heights.ElementAt(BoxIndex);
                cbx_height.SelectedText = heights.ElementAt(BoxIndex).ToString();
                cbx_height.Text = heights.ElementAt(BoxIndex).ToString();

                if (doors_color[BoxIndex] == "Verre")
                {
                    checkBox_glass.Checked = true;
                }
                else if (doors_color[BoxIndex] != null)
                {
                    checkBox_wood.Checked = true;
                    cbx_door_color.Text = doors_color[BoxIndex];
                }
                else
                {
                    checkBox_wood.Checked = false;
                    checkBox_glass.Checked = false;
                    cbx_door_color.Text = "";
                }

            }

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
            bool completeCabinet = true;
            bool checkComplete = false;
            int boxesAmount = this.colors.Count;
            int boxindex = 0;

            while (!checkComplete)
            {

                if (this.colors[boxindex] != "" && this.heights[boxindex] != 0)
                {
                    if (boxindex < boxesAmount - 1)
                    {
                        boxindex++;
                    }
                    else
                    {
                        checkComplete = true;
                    }

                }
                else
                {
                    MessageBox.Show("Veuillez au minimum choisir une hauteur et une couleur pour l'étage " + (boxindex + 1).ToString() + ".", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkComplete = true;
                    completeCabinet = false;
                }

            }

            if (completeCabinet)
            {
                order.AddCabinet(this.depth, this.width, heights.Sum(), this.corner_color);
                List<Cabinet> cabinets = order.GetCabinets;
                int index_of_cabinet = cabinets.Count - 1;

                for (int i = 0; i < this.heights.Count; i++)
                {
                    cabinets[index_of_cabinet].AddBox(heights[i], width, depth, colors[i], doors[i], doors_color[i]);
                    order.AddLastBoxElementsToDico();

                }
                order.AddCornerToDico();


                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new UC_Custom(order, this.depth, this.width, this.corner_color));
            }

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Introduction());
        }

        private void cbx_height_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_height.SelectedItem != null)
            {
                this.heights[BoxIndex] = Int32.Parse(cbx_height.SelectedItem.ToString());
            }
                
        }

        private void cbx_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_color.SelectedItem != null)
            {
                this.colors[BoxIndex] = cbx_color.SelectedItem.ToString();
            }
        }

        private void checkBox_wood_CheckedChanged(object sender, EventArgs e)
        {
           
            cbx_door_color.Hide();
            panel_door_color.Hide();
            if (checkBox_wood.Checked)
            {
                cbx_door_color.Show();
                panel_door_color.Show();
                panel_door_color.BackColor = System.Drawing.Color.White;
                checkBox_glass.Checked = false;
                cbx_door_color.Text = doors_color[BoxIndex];
                if (doors_color[BoxIndex] == null || doors_color[BoxIndex] == "Verre")
                {
                    cbx_door_color.Text = "Blanc";
                }

            }


        }

    private void cbx_door_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_door_color.Text == "Brun")
            {
                panel_door_color.BackColor = System.Drawing.Color.Maroon;
                doors_color[BoxIndex] = cbx_door_color.Text;
            }
            else if (cbx_door_color.Text == "Blanc")
            {
                panel_door_color.BackColor = System.Drawing.Color.White;
                doors_color[BoxIndex] = cbx_door_color.Text;
            }
            doors[BoxIndex] = true;

        }

        private void checkBox_glass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_glass.Checked == true)
            {
                doors[BoxIndex] = true;
                doors_color[BoxIndex] = "Verre";
                checkBox_wood.Checked = false;
            }        
        }

        private void GoToCart_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UC_Cart(order));
        }
    }
}
