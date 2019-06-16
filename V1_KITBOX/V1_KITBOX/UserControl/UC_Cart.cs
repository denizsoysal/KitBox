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


                function.Update("kitbox_database.`client`", "NomClient='" + tbxLastname.Text + "' , PrenomClient = '" + tbxFirstname.Text + "'", "idClient='" + Customer_ID + "'");
                function.Insert3("kitbox_database.`commande`", "`PanneauHB`", "`PanneauGD`", "`Porte`", "`Tasseau`", "`PanneauAR`", "`TraverseAV`", "`TraverseGD`", "`TraverseAR`", "`Corniere`", "`client_fk`", "`Command_state`", "`number_of_box`", "'" + PannelHBCode + "'", "'" + PannelGDCode + "'", "'" + DoorCode + "'", "'" + TasseauCode + "'", "'" + PannelARCode + "'", "'" + TraverseAVCode + "'", "'" + TraverseGDCode + "'", "'" + TraverseARCode + "'", "'" + CorniereCode + "'", "'" + Customer_ID + "'", "'" + CommandState + "'", "'" + totalBoxes + "'");
 

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


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        public void buttonValidateAndPay_Click(object sender, EventArgs e)
        {
            LoadData();

            MessageBox.Show("Merci pour votre commande "+ tbxFirstname.Text+" "+ tbxLastname.Text+",\nà bientot !","Commande enregistrée");
            this.Controls.Clear();
            this.Controls.Add(new Introduction());
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


        }

        private void lbx_boxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCabinet = lbx_cabinets.SelectedIndex;
            int selectedBox = lbx_boxes.SelectedIndex;
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
