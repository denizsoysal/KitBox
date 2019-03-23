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

    public partial class frmWM : Form
    {
         string connectionString = "SERVER=127.0.0.1; DATABASE=test; UID=root; PASSWORD=";
        private MySqlConnection connection;
        public frmWM()
        {
            
            this.InitConnexion();
            
            InitializeComponent();
           
        }
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=test; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }
        public String Selectionner(string Select, string From, string Where)
        {
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            string CommandString = "SELECT " + Select + " FROM " + From;
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySql.Data.MySqlClient.MySqlDataReader Reader;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
             Reader.GetString(Where);
            }
            return Reader.GetString(Where);
        }

        public void Inserer(string Insert, string Column, string Values)
        {
            connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "INSERT INTO `"+Insert +"` (`"+Column+"`) VALUES('"+Values+"')";
            cmd.ExecuteNonQuery();
            this.connection.Close();
        }


        private void SaveDate(object sender, EventArgs e)
        {
            Inserer("winforms","Date", Convert.ToString(DateTime.Now));
            
            /*this.connection.Open();
            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = this.connection.CreateCommand();
            // Requête SQL
            cmd.CommandText = "INSERT INTO `winforms` (`Date`, `Temperature`, `Humidity`) VALUES('" + Convert.ToString(DateTime.Now) + "','" + tbxTemperature.Text + "','" + tbxHumidity.Text + "')";
           // Exécution de la commande SQL
            cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            this.connection.Close();*/
        }

       /* private void LoadData(object sender, EventArgs e)
        {
            string ConnectionString = "server=localhost;uid=root;pwd=;database=test";
            MySql.Data.MySqlClient.MySqlConnection Connection;
            Connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
            Connection.Open();

            string CommandString = "SELECT * FROM winforms";
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, Connection);
            MySql.Data.MySqlClient.MySqlDataReader Reader;
            Reader = Command.ExecuteReader();

            while (Reader.Read()) {
                lblDate.Text = Reader.GetString("Date");
                lblTemperature.Text = Reader.GetString("Temperature");
                lblHumidity.Text = Reader.GetString("Humidity");
                string sDate = Reader.GetString("Date");
                cbxChoose.Items.Add(Reader.GetString("sDate"));
                //cbxChoose.DataSource = ds.Tables[0];
            }
            
        }*/

        private void Form_Load(object sender, EventArgs e)
        {
          //  cbxChoose.Items.Add(Selectionner("*", "winforms", "Date"));
        }
    }
}
