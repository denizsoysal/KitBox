using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1_KITBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

         MessageBox.Show("Boxe not available");

            
        }

        private void comboBoxHigh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxLength.Items.Contains("10"))
            {
                comboBoxLength.Items.Insert(0, "10");
            }

            if (comboBoxHigh.Text == "10")
            {
                comboBoxLength.Items.Remove("10");
                // comboBoxLength.Items.Remove();

            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
