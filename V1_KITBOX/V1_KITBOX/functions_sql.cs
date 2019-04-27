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

        public static string Select2(string Select, string From, string Where)
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
                
            }
            return Reader.GetString(Select);
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
        public static String Return0(string Select, string From, string WhereOne, string ComboOne)
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            string CommandString = "SELECT DISTINCT " + Select + " FROM " + From + " WHERE " + WhereOne + "='" + ComboOne + "'";
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySql.Data.MySqlClient.MySqlDataReader Reader;
            Reader = Command.ExecuteReader();


            while (Reader.Read())
            {

            }
            return Reader.GetString(Select);

        }

        public static String Returna(string Select)
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            string CommandString = Select ;
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySql.Data.MySqlClient.MySqlDataReader Reader;
            Reader = Command.ExecuteReader();


            while (Reader.Read())
            {

            }
            return Reader.GetString(Select);

        }

        public static String Return2(string Select, string From, string WhereOne, string ComboOne, string WhereTwo, string ComboTwo, string WhereThree, string ComboThree)
        {

            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            string CommandString = "SELECT DISTINCT " + Select + " FROM " + From + " WHERE " + WhereOne + "='" + ComboOne + "' AND " + WhereTwo + "='" + ComboTwo + "' AND " + WhereThree + "='" + ComboThree + "'";
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySql.Data.MySqlClient.MySqlDataReader Reader;
            Reader = Command.ExecuteReader();
            Reader.Read();

            while (Reader.Read())
            {

            }
            return Reader.GetString(Select);

        }

        public static String Return3(string Select, string From, string WhereOne, string ComboOne, string WhereTwo, string ComboTwo, string WhereThree, string ComboThree, string WhereFour, string ComboFour)
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            //PannelARCode = function.Return3("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", BoxHeight, "Largeur", widdth, "Couleur", BoxColor, "Reference", PannelAR);
            // string CommandString = "SELECT CodeBarre FROM `kitbox` WHERE `Reference`='Panneau Ar' AND `Hauteur` = '42' AND `Largeur` = '120' AND `Couleur` = 'Blanc'";
            string CommandString = "SELECT " + Select + " FROM " + From + " WHERE " + WhereOne + "='" + ComboOne + "' AND " + WhereTwo + "='" + ComboTwo + "' AND " + WhereThree + "='" + ComboThree + "' AND " + WhereFour + "='" + ComboFour + "'";
            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySql.Data.MySqlClient.MySqlDataReader Reader;
            Reader = Command.ExecuteReader();


            while (Reader.Read())
            {

            }
            return Reader.GetString(Select);
            //Reader.Read();
            //return Reader.GetString(Select);

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
        public static void Insert2(string Insert, string Column1, string Column2, string Column3, string Column4, string Column5, string Column6, string Column7, string Column8, string Column9, string Column10, string Value1, string Value2, string Value3 , string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10)
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            //cmd.CommandText = "INSERT INTO " + Insert + " (" + Column + ") VALUES(" + Values + ")";
            cmd.CommandText = "INSERT INTO " + Insert + "(" + Column1 +"," + Column2 + "," + Column3 + "," + Column4 + "," + Column5 + "," + Column6 + "," + Column7 + "," + Column8 + "," + Column9 + "," + Column10 + ") values(" + Value1 + "," + Value2 + "," + Value3 + "," + Value4 + "," + Value5 + "," + Value6 + "," + Value7 + "," + Value8 + "," + Value9 + "," + Value10 + ")";
            
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        public static void Update(string Update, string Set, string Where)
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
            MySqlConnection connection;
           // connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
           //tring CommandString = "update kitbox_database.kitbox set Enstock='" + this.Enstock.Text + "' where CodeBarre='" + this.CodeBarre.Text + "';";
          //  string CommandString = "update "+ Update + "set "+ Set + "='"+ value + "' where " + Where + "='" + value2 +"'";
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
