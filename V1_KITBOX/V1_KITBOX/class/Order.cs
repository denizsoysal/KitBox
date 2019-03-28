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
        private Dictionary<string, int> orderElements;

        public Order(int nbr)
        {
            this.orderNbr = nbr;     // Prendre le numero de commande dans la database au lieu de "nbr" en paramètre
            cabinets = new List<Cabinet>();
            orderElements = new Dictionary<string, int>();
            //MessageBox.Show("Commande numéro " + orderNbr.ToString() + " créée.");
        }
    
        public void AddCabinet(int depth, int width, int height, string corner_color)
        {
                this.cabinets.Add(new Cabinet(depth, width, height, corner_color));
        }

        public void AddCornerToDico()
        {
            string cornerCode = cabinets[cabinets.Count - 1].GetCorner().GetCode();
            if (!orderElements.ContainsKey(cornerCode))
            {
                orderElements.Add(cornerCode, 4);
            }
            else
            {
                orderElements[cornerCode] = orderElements[cornerCode] + 4;
            }

        }
        public void AddLastBoxElementsToDico()
        {
            Boxe lastBox = cabinets[cabinets.Count - 1].getLastBox();
            foreach (Element elem in lastBox.GetElem())
            {
                string code = elem.GetCode();

                if (!orderElements.ContainsKey(code))
                {
                    orderElements.Add(code, 1);
                }
                else
                {
                    orderElements[code] = orderElements[code] + 1;
                }
            }

        }


        
        
        public List<Cabinet> GetCabinet { get { return cabinets; }  }
        public Dictionary<string,int> getOrderElements { get { return orderElements; } }

   }
}
