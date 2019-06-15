using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace V1_KITBOX
{
    public partial class Introduction : UserControl
    {
        string connectionString = "SERVER=127.0.0.1; DATABASE=kitbox_database; UID=root; PASSWORD=";
        private MySqlConnection connection;
        Order order;
        public Introduction()
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



            int orderNumber = 3456;  // Chercher dans la databse le numéro d'une nouvelle commande
            this.order = new Order(orderNumber);
            this.Controls.Clear();
            this.Controls.Add(new UC_OrderP1(order));
        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }
    }
}

