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
    
    public void AddCabinet(Cabinet AddedCabinet)
    {
            this.cabinets.Add(AddedCabinet);

    }

   }
}
