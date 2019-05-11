﻿using System;
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
    public partial class idCommand : Form
    {
        string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
        private MySqlConnection connection;

        public idCommand()
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
            string CommandString = "SELECT * FROM `kitbox_database`.`commande` ";
            // MySqlCommand command = new MySqlCommand("SELECT Dimensions FROM `kitbox_database`.`kitbox` WHERE Reference='Cornieres'");
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            // MySql.Data.MySqlClient.MySqlDataReader Reader;
            // Reader = Command.ExecuteReader();

            //while (Reader.Read())
            // {


            // combo.Items.Add(Reader.GetString("Dimensions"));
            // }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string etat = "Terminée";
            string CommandString = "update kitbox_database.commande set Command_state='" + etat + "' where idCommande='" + this.id_Command.Text + "';";

            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySqlDataReader myReader;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            // connection.Open();
            string CommandString = "delete from kitbox_database.commande where idCommande='" + this.id_Command.Text + "' ;";

            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySqlDataReader myReader;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
