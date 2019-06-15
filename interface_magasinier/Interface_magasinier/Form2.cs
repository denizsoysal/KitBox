using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinForms_MySQL
{
    public partial class Form2 : Form
    {
        string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
        private MySqlConnection connection;
        public Form2()
        {

            this.InitConnexion();

            InitializeComponent();

            LoadTable();

        }
        private void InitConnexion()
        {

            this.connection = new MySqlConnection(connectionString);
        }

        void LoadTable()
        {
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            string CommandString = "SELECT * FROM `kitbox_database`.`kitbox` ";
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);




            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = Command;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

            connection.Close();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            string CommandString = "SELECT * FROM `kitbox_database`.`kitbox` ";
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);




            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = Command;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                                                          
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

            connection.Close();

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            string CommandString = "update kitbox_database.kitbox set Enstock='" + this.Enstock.Text + "' where CodeBarre='" + this.CodeBarre.Text + "';";

            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySqlDataReader myReader;
            if (CodeBarre.Text.Trim() == string.Empty || Enstock.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please make sure that all fields are completed");
                return; // return because we don't want to run normal code of buton click
            }
            else
            {
                try
                {
                    connection.Open();
                    myReader = Command.ExecuteReader();
                    MessageBox.Show("saved");
                    while (myReader.Read())
                    {


                    }




                }






                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }
                LoadTable();
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string CommandString = "delete from kitbox_database.kitbox where CodeBarre='" + this.Code_Barre.Text + "' ;";

            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySqlDataReader myReader;
            if (CodeBarre.Text.Trim() == string.Empty || Enstock.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please make sure that all fields are completed");
                return; // return because we don't want to run normal code of buton click
            }
            else
            {

                try
                {
                    connection.Open();
                    myReader = Command.ExecuteReader();
                    MessageBox.Show("saved");
                    while (myReader.Read())
                    {


                    }




                }
  



                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }
                LoadTable();
                connection.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void Reference_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CodeBarre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                CodeBarre.Text = row.Cells["CodeBarre"].Value.ToString();
                Enstock.Text = row.Cells["Enstock"].Value.ToString();
                Code_Barre.Text = row.Cells["CodeBarre"].Value.ToString();
                                                                      
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.ShowDialog();
        }

        private void Enstock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
