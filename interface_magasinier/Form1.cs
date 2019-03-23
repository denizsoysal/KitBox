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
    public partial class Form1 : Form
    {
        string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
        private MySqlConnection connection;
        public Form1()
        {
            this.InitConnexion();
            InitializeComponent();
        }
        private void InitConnexion()
        {

            this.connection = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
               // connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
              //  connection.Open();
                string CommandString = "insert into kitbox_database.kitbox (Reference,CodeBarre,Dimensions,Hauteur,Profondeur,Largeur,Couleur,Enstock,StockMinimum,PrixClient,NbPiecesCasier,PrixFourn1,DelaiFourn1,PrixFourn2,DelaiFourn2) values('" + this.REF.Text + "','" + this.CodeBarre.Text + "','" + this.Dimensions.Text + "','" + this.Hauteur.Text + "','" + this.Profondeur.Text + "','" + this.Largeur.Text + "','" + this.Couleur.Text + "','" + this.EnStock.Text + "','" + this.StockMinimum.Text + "','" + this.PrixClient.Text + "','" + this.NbPecesCasier.Text + "','" + this.PrixFourn1.Text + "','" + this.DelaiFourn1.Text + "','" + this.PrixFourn2.Text + "','" + this.DelaiFourn2.Text + "') ;";
                //
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
                
                connection.Close();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
