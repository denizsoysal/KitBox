using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_KITBOX
{
    class Command
    {
        private int commandNbr;
        private float amount;
        private string client;
        private List<Cabinet> cabinets;
        // cabinets.Add(new Cabinet()); pour ajouter une armoire à la commande
        public Command(int nbr)
        {
            this.commandNbr = nbr;
            cabinets= new List<Cabinet>();
        }
     
    }
}
