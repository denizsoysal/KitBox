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

namespace V1_KITBOX
{
    public static class function
    {
        public static void ConnectionClose()
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Close();
        }

        public static void Select(string Select, string From, string Where, ComboBox Combo)
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            connection.Open();
            string CommandString = "SELECT DISTINCT " + Select + " FROM " + From + " WHERE " + Where;
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySql.Data.MySqlClient.MySqlDataReader Reader;
            Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                Combo.Items.Add(Reader.GetString(Select));
            }

        }

        public static void Fill(string Select, string From, string Where, ComboBox Combo)
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            string CommandString = "SELECT DISTINCT " + Select + " FROM " + From + " WHERE " + Where;
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySql.Data.MySqlClient.MySqlDataReader Reader;
            Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                Combo.Items.Add(Reader.GetString(Select));
            }

        }

        public static String Return(string Select, string From, string WhereOne, ComboBox ComboOne, string WhereTwo, ComboBox ComboTwo, Label Lab)
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            Object SelectedOne = ComboOne.SelectedItem;
            Object SelectedTwo = ComboTwo.SelectedItem;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            string CommandString = "SELECT DISTINCT " + Select + " FROM " + From + " WHERE " + WhereOne + "='" + SelectedOne + "' AND " + WhereTwo + "='" + SelectedTwo + "'";
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySql.Data.MySqlClient.MySqlDataReader Reader;
            Reader = Command.ExecuteReader();


            while (Reader.Read())
            {

            }
            return Lab.Text = Reader.GetString(Select);

        }

        public static void Insert(string Insert, string Column, string Values)
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO " + Insert + " (" + Column + ") VALUES(" + Values + ")";
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(string Update, string Set, string Where)
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            string CommandString = "UPDATE " + Update + " SET " + Set + " WHERE " + Where + "";
            MySqlCommand cmd = new MySqlCommand(CommandString, connection);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
                connection.Close();
        }

        public static void Delete(string Delete, string Where)
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            string CommandString = "DELETE FROM " + Delete + " WHERE " + Where + "";
            MySqlCommand cmd = new MySqlCommand(CommandString, connection);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            connection.Close();
        }

        //Return("CodeBarre", "kitbox_database.`kitbox`", "Dimensions", cbxDim, "Couleur", cbxCoul, lblDate);


        //Insert("kitbox_database.`Client`", "`NomClient`,`PrenomClient`",  "'Itunime', 'Rudy'");

        //Fill("Couleur", "kitbox_database.`kitbox`", "Reference='Cornieres'", cbxCoul);

        //Update("kitbox_database.`Client`", "NomClient  = 'Masala'", "PrenomClient = 'Rudy'");

        //Delete("kitbox_database.`Client`", "idClient = '3'");
    }
}
