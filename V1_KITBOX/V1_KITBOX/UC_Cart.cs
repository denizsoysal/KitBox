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
            for(int i=0; i< this.order.GetCabinets.Count;i++)
            {
                lbx_cabinets.Items.Add("Armoire " +(i+1).ToString() );
                totalBoxes = totalBoxes+ order.GetCabinets[i].GetNumberBoxes();
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

            int totalBoxes = 3;
            for (int i = 0; i < this.order.GetCabinets.Count; i++)
            {

                totalBoxes = totalBoxes + order.GetCabinets[i].GetNumberBoxes();

            }

                

            int selectedBox = lbx_boxes.SelectedIndex;

  
            string BoxHeight_before = order.GetCabinets[selectedCabinet].GetBoxes[selectedBox].GetHeight.ToString();
            int Boxheight_int = Int32.Parse(BoxHeight_before) - 4;
            string BoxHeight = Boxheight_int.ToString();
            int TotalHeight_int = (Boxheight_int+4)*totalBoxes;
            string TotalHeight = TotalHeight_int.ToString();

            label1.Text = BoxHeight; //prix
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

           PannelHBCode = function.Return2("CodeBarre", "kitbox_database.`kitbox`", "Largeur", widdth, "Profondeur", deppth, "Couleur", Corner_color); //code barre du panneau HB 
           PannelGDCode = function.Return2("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", BoxHeight, "Profondeur", deppth, "Couleur", BoxColor); //code barre du panneau GD
           DoorCode = function.Return2("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", BoxHeight, "Largeur", widdth, "Couleur", Door_color); //code barre de la porte
           TasseauCode = function.Return0("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", BoxHeight); //code barre du tausseau
           TraverseAVCode = function.Return3("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", "0", "Profondeur", "0", "Largeur", widdth, "`Reference`", "Traverse Av"); //code barre de la porte
           TraverseGDCode = function.Return2("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", "0", "Largeur", "0", "Profondeur", deppth); //code barre de la porte
           TraverseARCode = function.Return3("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", "0", "Profondeur", "0", "Largeur", widdth, "`Reference`", "Traverse Ar"); //code barre de la porte
           CorniereCode = function.Return2("CodeBarre", "kitbox_database.`kitbox`", "Hauteur", TotalHeight, "`Reference`", "Cornieres", "Couleur", Corner_color); //code barre de la porte
           Customer_ID = function.Select2("idClient", "kitbox_database.`client`", "idClient");

              //  Customer_ID = Customer_ID.ToString();
               function.Update("kitbox_database.`client`", "NomClient='" + tbxLastname.Text+ "' , PrenomClient = '" + tbxFirstname.Text+"'", "idClient='" + Customer_ID+"'");
               // function.Update("kitbox_database.`client`", "NomClient='" + tbxLastname.Text + "'", "idClient='" + Customer_ID + "'");
                //  function.Update("kitbox_database.`client`", "NomClient"+ tbxLastname.Text + ", PrenomClient = '" + tbxFirstname.Text + "'", "client_fk = '" + Customer_ID + "'");
             PannelARCode = function.Return3("CodeBarre", "kitbox_database.`kitbox`", "`Reference`", "Panneau Ar" , "`Hauteur`", BoxHeight, "`Largeur`", widdth, "`Couleur`", BoxColor);
             function.Insert2("kitbox_database.`commande`", "`PanneauHB`", "`PanneauGD`", "`Porte`", "`Tasseau`", "`PanneauAR`", "`TraverseAV`", "`TraverseGD`", "`TraverseAR`", "`Corniere`", "`client_fk`", "'" + PannelHBCode + "'", "'" + PannelGDCode + "'", "'" + DoorCode + "'" , "'" + TasseauCode + "'", "'" + PannelARCode + "'", "'" + TraverseAVCode + "'", "'" + TraverseGDCode + "'", "'" + TraverseARCode + "'", "'" + CorniereCode + "'", "'" + Customer_ID + "'");
             
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

    }
}
