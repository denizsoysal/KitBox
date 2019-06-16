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
using System.IO;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                id_Command.Text = row.Cells["idCommande"].Value.ToString();


            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string etat = "Terminée";
            string CommandString = "update kitbox_database.commande set Command_state='" + etat + "' where idCommande='" + this.id_Command.Text + "';";

            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySqlDataReader myReader;
            if (id_Command.Text.Trim() == string.Empty)
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

                string CorniereCode = "";
                string PanneauARCode = "";
                string PanneauGDCode = "";
                string PanneauHBCode = "";
                string PorteCode = "";
                string TasseauCode = "";
                string TraverseARCode = "";
                string TraverseAVCode = "";
                string TraverseGDCode = "";
                string totalBoxes_str = "";

                CorniereCode = function.Return("Corniere", "idCommande", this.id_Command.Text);
                PanneauARCode = function.Return("PanneauAR", "idCommande", this.id_Command.Text);
                PanneauGDCode = function.Return("PanneauGD", "idCommande", this.id_Command.Text);
                PanneauHBCode = function.Return("PanneauHB", "idCommande", this.id_Command.Text);
                PorteCode = function.Return("Porte", "idCommande", this.id_Command.Text);
                TasseauCode = function.Return("Tasseau", "idCommande", this.id_Command.Text);
                TraverseARCode = function.Return("TraverseAR", "idCommande", this.id_Command.Text);
                TraverseAVCode = function.Return("TraverseAV", "idCommande", this.id_Command.Text);
                TraverseGDCode = function.Return("TraverseGD", "idCommande", this.id_Command.Text);
                totalBoxes_str = function.Return("number_of_box", "idCommande", this.id_Command.Text);
                int totalBoxes = Int32.Parse(totalBoxes_str);

                string CorniereStock = "";
                string PannelARStock = "";
                string PannelGDStock = "";
                string PannelHBStock = "";
                string DoorStock = "";
                string TasseauStock = "";
                string TraverseAVStock = "";
                string TraverseARStock = "";
                string TraverseGDStock = "";

                CorniereStock = function.Return2("Enstock", "CodeBarre", CorniereCode);
                PannelARStock = function.Return2("Enstock", "CodeBarre", PanneauARCode);
                PannelGDStock = function.Return2("Enstock", "CodeBarre", PanneauGDCode);
                PannelHBStock = function.Return2("Enstock", "CodeBarre", PanneauHBCode);
                DoorStock = function.Return2("Enstock", "CodeBarre", PorteCode);
                TasseauStock = function.Return2("Enstock", "CodeBarre", TasseauCode); ;
                TraverseAVStock = function.Return2("Enstock", "CodeBarre", TraverseAVCode);
                TraverseARStock = function.Return2("Enstock", "CodeBarre", TraverseARCode);
                TraverseGDStock = function.Return2("Enstock", "CodeBarre", TraverseGDCode);
                //
                string CorniereUpdate = (Int32.Parse(CorniereStock) - 4).ToString();
                string PannelARUpdate = (Int32.Parse(PannelARStock) - 1 * totalBoxes).ToString();
                string PannelGDUpdate = (Int32.Parse(PannelGDStock) - 2 * totalBoxes).ToString();
                string PannelHBUpdate = (Int32.Parse(PannelHBStock) - 2 * totalBoxes).ToString();
                string DoorUpdate = (Int32.Parse(DoorStock) - 2 * totalBoxes).ToString();
                string TasseauUpdate = (Int32.Parse(TasseauStock) - 4 * totalBoxes).ToString();
                string TraverseAVUpdate = (Int32.Parse(TraverseAVStock) - 2 * totalBoxes).ToString();
                string TraverseARUpdate = (Int32.Parse(TraverseARStock) - 2 * totalBoxes).ToString();
                string TraverseGDUpdate = (Int32.Parse(TraverseGDStock) - 4 * totalBoxes).ToString();


                function.Update(CorniereUpdate, CorniereCode);
                function.Update(PannelARUpdate, PanneauARCode);
                function.Update(PannelGDUpdate, PanneauGDCode);
                function.Update(PannelHBUpdate, PanneauHBCode);
                function.Update(DoorUpdate, PorteCode);
                function.Update(TasseauUpdate, TasseauCode);
                function.Update(TraverseAVUpdate, TraverseAVCode);
                function.Update(TraverseARUpdate, TraverseARCode);
                function.Update(TraverseGDUpdate, TraverseGDCode);
                LoadTable();
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string CommandString = "delete from kitbox_database.commande where idCommande='" + this.id_Command.Text + "' ;";

            MySql.Data.MySqlClient.MySqlCommand Command;
            Command = new MySql.Data.MySqlClient.MySqlCommand(CommandString, connection);
            MySqlDataReader myReader;
            if (id_Command.Text.Trim() == string.Empty)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.ShowDialog();
        }

        public void Print_Click(object sender, EventArgs e)
        {



            string CorniereCode = function.Return("Corniere", "idCommande", this.id_Command.Text);
            string PanneauARCode = function.Return("PanneauAR", "idCommande", this.id_Command.Text);
            string PanneauGDCode = function.Return("PanneauGD", "idCommande", this.id_Command.Text);
            string PanneauHBCode = function.Return("PanneauHB", "idCommande", this.id_Command.Text);
            string PorteCode = function.Return("Porte", "idCommande", this.id_Command.Text);
            string TasseauCode = function.Return("Tasseau", "idCommande", this.id_Command.Text);
            string TraverseARCode = function.Return("TraverseAR", "idCommande", this.id_Command.Text);
            string TraverseAVCode = function.Return("TraverseAV", "idCommande", this.id_Command.Text);
            string TraverseGDCode = function.Return("TraverseGD", "idCommande", this.id_Command.Text);
            string Customer_ID = function.Return("client_fk", "idCommande", this.id_Command.Text); ;
            string Command_ID = function.Return("idCommande", "idCommande", this.id_Command.Text);
            string TotalPrice = "En cours de négociation";
            //

            //
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "C:\" ";
            saveFileDialog1.Title = "Save the facture " + Command_ID;
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "Facture.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveFileDialog1.FileName);
                Encoding asciiEncoding = Encoding.ASCII;
                file.Write("KitBox, L'armoire sur mesure.");
                file.Write("\r\n");
                file.Write("Client n°: " + Customer_ID);
                file.Write("\r\n");
                file.Write("Commande n°: " + Command_ID);
                file.Write("\r\n");
                file.Write("\r\n");
                file.Write("Date et heure: " + Convert.ToString(DateTime.Now));

                file.Write("\r\n");
                file.Write("Cornière : " + CorniereCode);
                file.Write("\r\n");
                file.Write("PanneauHB: " + PanneauHBCode);
                file.Write("\r\n");
                file.Write("PanneauGD: " + PanneauGDCode);
                file.Write("\r\n");
                file.Write("PanneauAR: " + PanneauARCode);
                file.Write("\r\n");
                file.Write("Porte: " + PorteCode);
                file.Write("\r\n");
                file.Write("Tasseau: " + TasseauCode);
                file.Write("\r\n");
                file.Write("TraverseAV: " + TraverseAVCode);
                file.Write("\r\n");
                file.Write("TraverseGD: " + TraverseGDCode);
                file.Write("\r\n");
                file.Write("TraverseAR: " + TraverseARCode);
                file.Write("\r\n");
                file.Write("Prix: " + TotalPrice);
                file.Write("\r\n");
                file.Write("\r\nA la prochaine");


                file.Close();
                MessageBox.Show("Le fichier a bien été créé dans l'emplacement spécifié!", "Facture", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}