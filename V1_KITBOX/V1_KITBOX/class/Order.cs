using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1_KITBOX
{
    public class Order
   {
        public int orderNbr;
       // private float amount;
        public string client;
        private List<Cabinet> cabinets;
        // cabinets.Add(new Cabinet()); pour ajouter une armoire à la commande
        public Order(int nbr)
        {
            this.orderNbr = nbr;
            cabinets = new List<Cabinet>();
            MessageBox.Show("Commande numéro " + orderNbr.ToString() + " créée.");
        }
    
        public void AddCabinet(int depth, int width, string corner_color)
        {
                this.cabinets.Add(new Cabinet(depth, width, corner_color));
        }

        public void AddBoxToCurrentCabinet(int height, string color, bool door, string door_color = null)
        {
            int indexOfCurrentCabinet = this.cabinets.Count -1;
            int width = this.cabinets[indexOfCurrentCabinet].GetWidth();
            int depth = this.cabinets[indexOfCurrentCabinet].GetDepth();
            this.cabinets[indexOfCurrentCabinet].AddBox(height, width, depth, color, door, door_color);
        }
    
        /*public void AddSimilarCabinet()
        {
            int indexOfCurrentCabinet = this.cabinets.Count - 1;
            int width = this.cabinets[indexOfCurrentCabinet].GetWidth();
            int depth = this.cabinets[indexOfCurrentCabinet].GetDepth();
            string corner_color = this.cabinets[indexOfCurrentCabinet].GetCornerColor();
            this.cabinets.Add(new Cabinet(depth, width, corner_color));
        }*/

        public List<Cabinet> getCabinets { get { return cabinets; }  }

   }
}
