using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_KITBOX
{
    public class Boxe
    {
        private int height;
        private int width;
        private int depth;
        private string color;
        private bool door;
        private string door_color;
        private List<Element> elements;
        
        public Boxe(int height, int width, int depth, string color, bool door, string door_color =  null)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.color = color;
            this.door = door;
            this.door_color = door_color;
            elements = new List<Element>();

            // Ajout des 2 Portes
            if ( door is true ) { AddDoor(); }
            // Ajout des 5 Panneaux
            AddPanel();
            // Ajout des 8 Traverses
            AddCleat();
            // Ajout des 4 Tasseaux
            AddCrossbar();
        }
        private void AddDoor()
        {
            int width_door;
            // Portes G/D
            if (width == 62)
            {
                width_door = width / 2 + 1;
              
                
            }
            else
            {
                width_door = width / 2 + 2;

            }

            if (door_color == "Blanc" || door_color == "Brun")
            {
                // Creation Coupelles
                Caps CG = new Caps();
                Caps CD = new Caps();
                elements.Add(CG);
                elements.Add(CD);

            }
            

            Door leftDoor = new Door(width_door, (height - 4), door_color);
            Door rightDoor = new Door(width_door, (height - 4), door_color);
            elements.Add(leftDoor);
            elements.Add(rightDoor);


        }

        private void AddCleat()
        {
            // 2 Traverses avant
            Cleat TAVB = new Cleat(width, 0, "AV");
            Cleat TAVH = new Cleat(width, 0, "AV");
            // 2 Traverses arrières
            Cleat TARB = new Cleat(width, 0, "AR");
            Cleat TARH = new Cleat(width, 0, "AR");
            // 4 Traverses GD
            Cleat TGB = new Cleat(0, depth, "G");
            Cleat TGH = new Cleat(0, depth, "G");
            Cleat TDB = new Cleat(0, depth, "D");
            Cleat TDH = new Cleat(0, depth, "D");
            elements.Add(TAVB);
            elements.Add(TAVH);
            elements.Add(TARB);
            elements.Add(TARB);
            elements.Add(TGB);
            elements.Add(TGH);
            elements.Add(TDB);
            elements.Add(TDH);
        }

        private void AddCrossbar()
        {
            // 4 Tasseaux
            Crossbar CARD = new Crossbar(height - 4);
            Crossbar CARG = new Crossbar(height - 4);
            Crossbar CAVD = new Crossbar(height - 4);
            Crossbar CAVG = new Crossbar(height - 4);
            elements.Add(CARD);
            elements.Add(CARG);
            elements.Add(CAVD);
            elements.Add(CAVG);

        }

        private void AddPanel()
        {
            // 5 Panels
            Panel PH = new Panel(0, depth,width,"HB",color);
            Panel PB =  new Panel(0, depth, width, "HB", color);
            Panel PG = new Panel(height - 4, depth, 0, "GD", color);
            Panel PD = new Panel(height - 4, depth, 0, "GD", color);
            Panel PAR = new Panel(height - 4, 0, width, "AR", color);
        }

        public List<Element> GetElem()
        {
            return elements;
        }
    }
}
