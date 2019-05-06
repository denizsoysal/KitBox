using System;
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
    public partial class UC_Cart : UserControl
    {
       // private List<string> cabinet;
        private Order order;
        public UC_Cart(Order currentOrder)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.order = currentOrder;

            for(int i=0; i< this.order.GetCabinets.Count;i++)
            {
                lbx_cabinets.Items.Add("Armoire " +(i+1).ToString() );
            }
            lbx_cabinets.SelectedIndex = 0;
            
            lbx_boxes.SelectedIndex = 0; // this call the changed selected item so we don't need to add the items here
            

            // provisoire, pour visualiser le dico des pièces,
            // montre comment accéder aux codes bares des pièces et leur nombre nécessaire
            /*string result = "";
            foreach (string code in order.getOrderElements.Keys)
            {
                result += code + " : ";
                result += order.getOrderElements[code].ToString() + "\n";
            }
            label3.Text = result;*/
        }

        


        private void UC_Cart_Load(object sender, EventArgs e)
        {
       
        }



        public void buttonValidateAndPay_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedCabinet = lbx_cabinets.SelectedIndex;
            lbx_boxes.Items.Clear();
            for (int j = 0; j < this.order.GetCabinets[selectedCabinet].GetBoxes.Count; j++)
            {
                lbx_boxes.Items.Add("Etage " + (j + 1).ToString());
            }
            lbx_boxes.SelectedIndex = 0;    // also calls the method ...IndexChanged()
            string deppth = order.GetCabinets[selectedCabinet].GetDepth().ToString(); //profondeur de l'armoire
            string widdth = order.GetCabinets[selectedCabinet].GetWidth().ToString(); //largeur de l'armoire
            string Corner_color = order.GetCabinets[selectedCabinet].GetCorner().GetColor().ToString(); //couleur des cornières



            int selectedBox = lbx_boxes.SelectedIndex;

            string BoxHeight = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetHeight.ToString();
            string BoxColor = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetColor;
            string Door_color = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetDoorColor;
//----

            
            string CorniereCode = "";
            string PannelARCode = "";
            string PannelGDCode = "";
            string PannelHBCode = "";
            string DoorCode = "";
            string TasseauCode = "";
            string TraverseAVCode = "";
            string TraverseARCode = "";
            string TraverseGDCode = "";

                int totalBoxes = 3;//!!!!!!!!!!!!!!!!!!
            int BoxHeightt = int.Parse(BoxHeight);
            int CornerHeight = (BoxHeightt + 4) * totalBoxes;
                string CornerHeightt = CornerHeight.ToString();
            string Customer_ID;

            //function.Insert("kitbox_database.`test`", "`depth`", "'" + deppth + "','" + widdth + "','" + Corner_color + "'");
            PannelHBCode = function.Return2("CodeBarre", "kitbox_database.`kitbox`", "Largeur", widdth, "Profondeur", deppth, "Couleur", Corner_color); //code barre du panneau HB 
            PannelGDCode = function.Return2("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", BoxHeight, "Profondeur", deppth, "Couleur", BoxColor); //code barre du panneau GD
            DoorCode = function.Return2("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", BoxHeight, "Largeur", widdth, "Couleur", Door_color); //code barre de la porte
            TasseauCode = function.Return0("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", BoxHeight); //code barre du tausseau
            TraverseAVCode = function.Return3("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", "0", "Profondeur", "0", "Largeur", widdth, "`Reference`", "Traverse Av"); //code barre de la porte
            TraverseGDCode = function.Return2("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", "0", "Largeur", "0", "Profondeur", deppth); //code barre de la porte
            TraverseARCode = function.Return3("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", "0", "Profondeur", "0", "Largeur", widdth, "`Reference`", "Traverse Ar"); //code barre de la porte
            CorniereCode = function.Return2("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", CornerHeightt, "`Reference`", "Cornieres", "Couleur", Corner_color); //code barre de la porte
            Customer_ID = function.Select2("idClient", "kitbox_database.`client`", "idClient");

              //  Customer_ID = Customer_ID.ToString();
               function.Update("kitbox_database.`client`", "NomClient='" + tbxLastname.Text+ "' , PrenomClient = '" + tbxFirstname.Text+"'", "idClient='" + Customer_ID+"'");
               // function.Update("kitbox_database.`client`", "NomClient='" + tbxLastname.Text + "'", "idClient='" + Customer_ID + "'");
                //  function.Update("kitbox_database.`client`", "NomClient"+ tbxLastname.Text + ", PrenomClient = '" + tbxFirstname.Text + "'", "client_fk = '" + Customer_ID + "'");
                // string CommandString = "SELECT CodeBarre FROM `kitbox` WHERE `Reference`='Panneau Ar' AND `Hauteur` = '42' AND `Largeur` = '120' AND `Couleur` = 'Blanc'";
                // PannelARCode = function.Returna("SELECT CodeBarre FROM `kitbox` WHERE `Reference`= 'Panneau Ar' AND `Hauteur` = '42' AND `Largeur` = '120' AND `Couleur` = 'Blanc'");
                PannelARCode = function.Return3("CodeBarre", "kitbox_database.`kitbox`", "`Reference`", "Panneau Ar" , "`Hauteur`", BoxHeight, "`Largeur`", widdth, "`Couleur`", BoxColor);
            function.Insert2("kitbox_database.`commande`", "`PanneauHB`", "`PanneauGD`", "`Porte`", "`Tasseau`", "`PanneauAR`", "`TraverseAV`", "`TraverseGD`", "`TraverseAR`", "`Corniere`", "`client_fk`", "'" + PannelHBCode + "'", "'" + PannelGDCode + "'", "'" + DoorCode + "'" , "'" + TasseauCode + "'", "'" + PannelARCode + "'", "'" + TraverseAVCode + "'", "'" + TraverseGDCode + "'", "'" + TraverseARCode + "'", "'" + CorniereCode + "'", "'" + Customer_ID + "'");

                //----

                string CorniereStock = "";
                string PannelARStock = "";
                string PannelGDStock = "";
                string PannelHBStock = "";
                string DoorStock = "";
                string TasseauStock = "";
                string TraverseAVStock = "";
                string TraverseARStock = "";
                string TraverseGDStock = "";

                CorniereStock = function.Return0("Enstock", "kitbox_database.`kitbox`", "CodeBarre", CorniereCode);
                PannelARStock = function.Return0("Enstock", "kitbox_database.`kitbox`", "CodeBarre", PannelARCode);
                PannelGDStock = function.Return0("Enstock", "kitbox_database.`kitbox`", "CodeBarre", PannelGDCode);
                PannelHBStock = function.Return0("Enstock", "kitbox_database.`kitbox`", "CodeBarre", PannelHBCode);
                DoorStock = function.Return0("Enstock", "kitbox_database.`kitbox`", "CodeBarre", DoorCode);
                TasseauStock = function.Return0("Enstock", "kitbox_database.`kitbox`", "CodeBarre", TasseauCode); ;
                TraverseAVStock = function.Return0("Enstock", "kitbox_database.`kitbox`", "CodeBarre", TraverseAVCode); 
                TraverseARStock = function.Return0("Enstock", "kitbox_database.`kitbox`", "CodeBarre", TraverseARCode);
                TraverseGDStock = function.Return0("Enstock", "kitbox_database.`kitbox`", "CodeBarre", TraverseGDCode);
                //
                string CorniereUpdate = (Int32.Parse(CorniereStock) - 4).ToString();
                string PannelARUpdate = (Int32.Parse(PannelARStock) - 1* totalBoxes).ToString();
                string PannelGDUpdate = (Int32.Parse(PannelGDStock) - 2 * totalBoxes).ToString();
                string PannelHBUpdate = (Int32.Parse(PannelHBStock) - 2 * totalBoxes).ToString();
                string DoorUpdate = (Int32.Parse(DoorStock) - 2 * totalBoxes).ToString();
                string TasseauUpdate = (Int32.Parse(TasseauStock) - 4 * totalBoxes).ToString();
                string TraverseAVUpdate = (Int32.Parse(TraverseAVStock) - 2 * totalBoxes).ToString();
                string TraverseARUpdate = (Int32.Parse(TraverseARStock) - 2 * totalBoxes).ToString();
                string TraverseGDUpdate = (Int32.Parse(TraverseGDStock) - 4 * totalBoxes).ToString();

                //

                string CorniereMin = "";
                string PannelARMin = "";
                string PannelGDMin = "";
                string PannelHBMin = "";
                string DoorMin = "";
                string TasseauMin = "";
                string TraverseAVMin = "";
                string TraverseARMin = "";
                string TraverseGDMin = "";

                CorniereMin = function.Return0("StockMinimum", "kitbox_database.`kitbox`", "CodeBarre", CorniereCode);
                PannelARMin = function.Return0("StockMinimum", "kitbox_database.`kitbox`", "CodeBarre", PannelARCode);
                PannelGDMin = function.Return0("StockMinimum", "kitbox_database.`kitbox`", "CodeBarre", PannelGDCode);
                PannelHBMin = function.Return0("StockMinimum", "kitbox_database.`kitbox`", "CodeBarre", PannelHBCode);
                DoorMin = function.Return0("StockMinimum", "kitbox_database.`kitbox`", "CodeBarre", DoorCode);
                TasseauMin = function.Return0("StockMinimum", "kitbox_database.`kitbox`", "CodeBarre", TasseauCode); ;
                TraverseAVMin = function.Return0("StockMinimum", "kitbox_database.`kitbox`", "CodeBarre", TraverseAVCode);
                TraverseARMin = function.Return0("StockMinimum", "kitbox_database.`kitbox`", "CodeBarre", TraverseARCode);
                TraverseGDMin = function.Return0("StockMinimum", "kitbox_database.`kitbox`", "CodeBarre", TraverseGDCode);

                //

                string CornierePrice= "";
                string PannelARPrice = "";
                string PannelGDPrice = "";
                string PannelHBPrice = "";
                string DoorPrice = "";
                string TasseauPrice = "";
                string TraverseAVPrice = "";
                string TraverseARPrice = "";
                string TraverseGDPrice = "";
                string TotalPrice = "";

                CornierePrice = function.Return0("PrixClient", "kitbox_database.`kitbox`", "CodeBarre", CorniereCode);
                CornierePrice = (float.Parse(CornierePrice) * 4).ToString();
                PannelARPrice = function.Return0("PrixClient", "kitbox_database.`kitbox`", "CodeBarre", PannelARCode);
                PannelARPrice = (float.Parse(PannelARPrice) * 1 * totalBoxes).ToString();
                PannelGDPrice = function.Return0("PrixClient", "kitbox_database.`kitbox`", "CodeBarre", PannelGDCode);
                PannelGDPrice = (float.Parse(PannelGDPrice) * 2 * totalBoxes).ToString();
                PannelHBPrice = function.Return0("PrixClient", "kitbox_database.`kitbox`", "CodeBarre", PannelHBCode);
                PannelHBPrice = (float.Parse(PannelHBPrice) * 2 * totalBoxes).ToString();
                DoorPrice = function.Return0("PrixClient", "kitbox_database.`kitbox`", "CodeBarre", DoorCode);
                DoorPrice = (float.Parse(DoorPrice) * 2 * totalBoxes).ToString();
                TasseauPrice = function.Return0("PrixClient", "kitbox_database.`kitbox`", "CodeBarre", TasseauCode); ;
                TasseauPrice = (float.Parse(TasseauPrice) * 4 * totalBoxes).ToString();
                TraverseAVPrice = function.Return0("PrixClient", "kitbox_database.`kitbox`", "CodeBarre", TraverseAVCode);
                TraverseAVPrice = (float.Parse(TraverseAVPrice) * 2 * totalBoxes).ToString();
                TraverseARPrice = function.Return0("PrixClient", "kitbox_database.`kitbox`", "CodeBarre", TraverseARCode);
                TraverseARPrice = (float.Parse(TraverseARPrice) * 2 * totalBoxes).ToString();
                TraverseGDPrice = function.Return0("PrixClient", "kitbox_database.`kitbox`", "CodeBarre", TraverseGDCode);
                TraverseGDPrice = (float.Parse(TraverseGDPrice) * 4 * totalBoxes).ToString();
                TotalPrice = (float.Parse(CornierePrice) + float.Parse(PannelARPrice) + float.Parse(PannelGDPrice) + float.Parse(PannelHBPrice) +  float.Parse(DoorPrice) + float.Parse(TasseauPrice) + float.Parse(TraverseAVPrice) + float.Parse(TraverseARPrice) + float.Parse(TraverseGDPrice)).ToString();

                lbltest.Text = TotalPrice + " €" ;

                //-----
                //function.Insert("kitbox_database.`commande`", "`PanneauHB`", "'" + PannelHBCode + "'");
                //function.Insert("kitbox_database.`commande`", "`PanneauGD`", "'" + PannelGDCode + "'");
                //string CommandString = "insert into kitbox_database.test (DelaiFourn2) values('" + this.REF.Text + "','" + this.CodeBarre.Text + "','" + this.Dimensions.Text + "','" + this.Hauteur.Text + "','" + this.Profondeur.Text + "','" + this.Largeur.Text + "','" + this.Couleur.Text + "','" + this.EnStock.Text + "','" + this.StockMinimum.Text + "','" + this.PrixClient.Text + "','" + this.NbPecesCasier.Text + "','" + this.PrixFourn1.Text + "','" + this.DelaiFourn1.Text + "','" + this.PrixFourn2.Text + "','" + this.DelaiFourn2.Text + "') ;";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UC_OrderP1(this.order));
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Introduction());
        }

        public void lbx_cabinets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCabinet = lbx_cabinets.SelectedIndex;
            lbx_boxes.Items.Clear();
            for (int j = 0; j < this.order.GetCabinets[selectedCabinet].GetBoxes.Count; j++)
            {
                lbx_boxes.Items.Add("Etage " + (j + 1).ToString());
            }
            lbx_boxes.SelectedIndex = 0;    // also calls the method ...IndexChanged()

            CabinetHeightValue.Text = order.GetCabinets[selectedCabinet].GetHeight().ToString();
          
            CabinetDepthValue.Text = order.GetCabinets[selectedCabinet].GetDepth().ToString();
            CabinetWidthValue.Text = order.GetCabinets[selectedCabinet].GetWidth().ToString();
            CabinetCornerColorValue.Text = order.GetCabinets[selectedCabinet].GetCorner().GetColor();
           /* string deppth = order.GetCabinets[selectedCabinet].GetDepth().ToString(); //profondeur de l'armoire
            string widdth = order.GetCabinets[selectedCabinet].GetWidth().ToString(); //largeur de l'armoire
            string Corner_color = order.GetCabinets[selectedCabinet].GetCorner().GetColor(); //couleur des cornières*/

        }

        private void lbx_boxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCabinet = lbx_cabinets.SelectedIndex;
            int selectedBox = lbx_boxes.SelectedIndex;

            BoxHeigthValue.Text = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetHeight.ToString();
            BoxColorValue.Text = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetColor;

            string doorColor = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetDoorColor;
            if(doorColor== null)
            {
                BoxDoorTypeValue.Text = "/";
                BoxDoorColorValue.Text = "/";
            }
            else if (doorColor == "Verre")
            {
                BoxDoorTypeValue.Text = "Verre";
                BoxDoorColorValue.Text = "Transparent";
            }
            else
            {
                BoxDoorTypeValue.Text = "Bois";
                BoxDoorColorValue.Text = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetDoorColor;
            }

            

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CabinetPriceValue_Click(object sender, EventArgs e)
        {

        }

        private void CabinetPrice_Click(object sender, EventArgs e)
        {

        }

        private void CabinetCornerColorValue_Click(object sender, EventArgs e)
        {

        }

        private void BoxHeigthValue_Click(object sender, EventArgs e)
        {

        }

        private void CabinetHeightValue_Click(object sender, EventArgs e)
        {

        }

        private void BoxDoorColorValue_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
