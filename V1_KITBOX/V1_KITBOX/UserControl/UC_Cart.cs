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
            int totalBoxes = 0;
            for (int i = 0; i < this.order.GetCabinets.Count; i++)
            {
                lbx_cabinets.Items.Add("Armoire " + (i + 1).ToString());
                totalBoxes = totalBoxes + order.GetCabinets[i].GetNumberBoxes();
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
            LoadData();
        }

        public void LoadData()
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

                int totalBoxes = 0;
                for (int i = 0; i < this.order.GetCabinets.Count; i++)
                {

                    totalBoxes = totalBoxes + order.GetCabinets[i].GetNumberBoxes();

                }



                int selectedBox = lbx_boxes.SelectedIndex;


                string BoxHeight_before = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetHeight.ToString();
                int Boxheight_int = Int32.Parse(BoxHeight_before) - 4;
                string BoxHeight = Boxheight_int.ToString();
                int TotalHeight_int = (Boxheight_int + 4) * totalBoxes;
                string TotalHeight = TotalHeight_int.ToString();

                //label1.Text = BoxHeight; //prix
                BoxHeigthValue.Text = BoxHeight;
                string BoxColor = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetColor;
                string Door_color = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetDoorColor;

                string PannelHBCode = "";
                string PannelGDCode = "";
                string DoorCode = "";
                string TasseauCode = "";
                string PannelARCode = "";
                string TraverseAVCode = "";
                string TraverseGDCode = "";
                string TraverseARCode = "";
                string CorniereCode = "";
                string Customer_ID;
                string CommandState = "Enregistrée";

                //function.Insert("kitbox_database.`test`", "`depth`", "'" + deppth + "','" + widdth + "','" + Corner_color + "'");
                PannelHBCode = function.CodeBarre("Largeur" + "='" + widdth + "' AND " + "Profondeur" + "='" + deppth + "' AND " + "Couleur" + "='" + Corner_color + "'"); //code barre du panneau HB 
                PannelGDCode = function.CodeBarre("Hauteur" + "='" + BoxHeight + "' AND " + "Profondeur" + "='" + deppth + "' AND " + "Couleur" + "='" + BoxColor + "'"); //code barre du panneau GD
                PannelARCode = function.CodeBarre("`Reference`" + "='" + "Panneau Ar" + "' AND " + "`Hauteur`" + "='" + BoxHeight + "' AND " + "`Largeur`" + "='" + widdth + "' AND " + "`Couleur`" + "='" + BoxColor + "'");
                DoorCode = function.CodeBarre("Hauteur" + "='" + BoxHeight + "' AND " + "Largeur" + "='" + deppth + "' AND " + "Couleur" + "='" + Door_color + "' AND " + "`Reference`" + "='" + "Porte" + "'"); //code barre de la porte
                TasseauCode = function.CodeBarre("Hauteur" + "='" + BoxHeight + "'"); //code barre du tausseau
                TraverseAVCode = function.CodeBarre("Hauteur" + "='" + "0" + "' AND " + "Profondeur" + "='" + "0" + "' AND " + "Largeur" + "='" + widdth + "' AND " + "`Reference`" + "='" + "Traverse Av" + "'"); //code barre de la porte
                TraverseGDCode = function.CodeBarre("Hauteur" + "='" + "0" + "' AND " + "Largeur" + "='" + "0" + "' AND " + "Profondeur" + "='" + deppth + "'"); //code barre de la porte
                TraverseARCode = function.CodeBarre("Hauteur" + "='" + "0" + "' AND " + "Profondeur" + "='" + "0" + "' AND " + "Largeur" + "='" + widdth + "' AND " + "`Reference`" + "='" + "Traverse Ar" + "'"); //code barre de la porte
                CorniereCode = function.CodeBarre("Hauteur" + "='" + TotalHeight.ToString() + "' AND " + "`Reference`" + "='" + "Cornieres" + "' AND " + "Couleur" + "='" + Corner_color + "'"); //code barre de la porte
                Customer_ID = function.Select2("idClient", "kitbox_database.`client`", "idClient");

                label8.Text = PannelHBCode;
                label9.Text = PannelGDCode;
                label10.Text = PannelARCode;
                label11.Text = DoorCode;
                label12.Text = TasseauCode;
                label13.Text = TraverseAVCode;
                label14.Text = TraverseGDCode;
                label15.Text = CorniereCode;
                label16.Text = Customer_ID;

                function.Update("kitbox_database.`client`", "NomClient='" + tbxLastname.Text + "' , PrenomClient = '" + tbxFirstname.Text + "'", "idClient='" + Customer_ID + "'");
                //function.Insert2("kitbox_database.`commande`", "`PanneauHB`", "`PanneauGD`", "`Porte`", "`Tasseau`", "`PanneauAR`", "`TraverseAV`", "`TraverseGD`", "`TraverseAR`", "`Corniere`", "`client_fk`", "'" + PannelHBCode + "'", "'" + PannelGDCode + "'", "'" + DoorCode + "'", "'" + TasseauCode + "'", "'" + PannelARCode + "'", "'" + TraverseAVCode + "'", "'" + TraverseGDCode + "'", "'" + TraverseARCode + "'", "'" + CorniereCode + "'", "'" + Customer_ID + "'");
                function.Insert3("kitbox_database.`commande`", "`PanneauHB`", "`PanneauGD`", "`Porte`", "`Tasseau`", "`PanneauAR`", "`TraverseAV`", "`TraverseGD`", "`TraverseAR`", "`Corniere`", "`client_fk`", "`Command_state`", "`number_of_box`", "'" + PannelHBCode + "'", "'" + PannelGDCode + "'", "'" + DoorCode + "'", "'" + TasseauCode + "'", "'" + PannelARCode + "'", "'" + TraverseAVCode + "'", "'" + TraverseGDCode + "'", "'" + TraverseARCode + "'", "'" + CorniereCode + "'", "'" + Customer_ID + "'", "'" + CommandState + "'", "'" + totalBoxes + "'");
                //----
                /*
                string CorniereStock = "";
                string PannelARStock = "";
                string PannelGDStock = "";
                string PannelHBStock = "";
                string DoorStock = "";
                string TasseauStock = "";
                string TraverseAVStock = "";
                string TraverseARStock = "";
                string TraverseGDStock = "";

                CorniereStock = function.Return("Enstock", "CodeBarre", CorniereCode);
                PannelARStock = function.Return("Enstock", "CodeBarre", PannelARCode);
                PannelGDStock = function.Return("Enstock", "CodeBarre", PannelGDCode);
                PannelHBStock = function.Return("Enstock", "CodeBarre", PannelHBCode);
                DoorStock = function.Return("Enstock", "CodeBarre", DoorCode);
                TasseauStock = function.Return("Enstock", "CodeBarre", TasseauCode); ;
                TraverseAVStock = function.Return("Enstock", "CodeBarre", TraverseAVCode);
                TraverseARStock = function.Return("Enstock", "CodeBarre", TraverseARCode);
                TraverseGDStock = function.Return("Enstock", "CodeBarre", TraverseGDCode);
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
                */
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

                CorniereMin = function.Return("StockMinimum", "CodeBarre", CorniereCode);
                PannelARMin = function.Return("StockMinimum", "CodeBarre", PannelARCode);
                PannelGDMin = function.Return("StockMinimum", "CodeBarre", PannelGDCode);
                PannelHBMin = function.Return("StockMinimum", "CodeBarre", PannelHBCode);
                DoorMin = function.Return("StockMinimum", "CodeBarre", DoorCode);
                TasseauMin = function.Return("StockMinimum", "CodeBarre", TasseauCode); ;
                TraverseAVMin = function.Return("StockMinimum", "CodeBarre", TraverseAVCode);
                TraverseARMin = function.Return("StockMinimum", "CodeBarre", TraverseARCode);
                TraverseGDMin = function.Return("StockMinimum", "CodeBarre", TraverseGDCode);

                //

                string CornierePrice = "";
                string PannelARPrice = "";
                string PannelGDPrice = "";
                string PannelHBPrice = "";
                string DoorPrice = "";
                string TasseauPrice = "";
                string TraverseAVPrice = "";
                string TraverseARPrice = "";
                string TraverseGDPrice = "";
                string TotalPrice = "";

                CornierePrice = function.Return("PrixClient", "CodeBarre", CorniereCode);
                CornierePrice = (float.Parse(CornierePrice) * 4).ToString();
                PannelARPrice = function.Return("PrixClient", "CodeBarre", PannelARCode);
                PannelARPrice = (float.Parse(PannelARPrice) * 1 * totalBoxes).ToString();
                PannelGDPrice = function.Return("PrixClient", "CodeBarre", PannelGDCode);
                PannelGDPrice = (float.Parse(PannelGDPrice) * 2 * totalBoxes).ToString();
                PannelHBPrice = function.Return("PrixClient", "CodeBarre", PannelHBCode);
                PannelHBPrice = (float.Parse(PannelHBPrice) * 2 * totalBoxes).ToString();
                DoorPrice = function.Return("PrixClient", "CodeBarre", DoorCode);
                DoorPrice = (float.Parse(DoorPrice) * 2 * totalBoxes).ToString();
                TasseauPrice = function.Return("PrixClient", "CodeBarre", TasseauCode); ;
                TasseauPrice = (float.Parse(TasseauPrice) * 4 * totalBoxes).ToString();
                TraverseAVPrice = function.Return("PrixClient", "CodeBarre", TraverseAVCode);
                TraverseAVPrice = (float.Parse(TraverseAVPrice) * 2 * totalBoxes).ToString();
                TraverseARPrice = function.Return("PrixClient", "CodeBarre", TraverseARCode);
                TraverseARPrice = (float.Parse(TraverseARPrice) * 2 * totalBoxes).ToString();
                TraverseGDPrice = function.Return("PrixClient", "CodeBarre", TraverseGDCode);
                TraverseGDPrice = (float.Parse(TraverseGDPrice) * 4 * totalBoxes).ToString();
                TotalPrice = (float.Parse(CornierePrice) + float.Parse(PannelARPrice) + float.Parse(PannelGDPrice) + float.Parse(PannelHBPrice) + float.Parse(DoorPrice) + float.Parse(TasseauPrice) + float.Parse(TraverseAVPrice) + float.Parse(TraverseARPrice) + float.Parse(TraverseGDPrice)).ToString();

                CabinetPriceValue.Text = TotalPrice + " €";
                CabinetPriceValue2.Text = TotalPrice + " €";


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

        public void buttonValidateAndPay_Click(object sender, EventArgs e)
        {
            LoadData();

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
            //BoxHeigthValue.Text = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetHeight.ToString();
            BoxColorValue.Text = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetColor;

            string doorColor = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetDoorColor;
            if (doorColor == null)
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

        private void BoxDoorTypeValue_Click(object sender, EventArgs e)
        {

        }
    }
}
