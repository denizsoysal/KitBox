using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace V1_KITBOX
{
    public class Boxe
    {
        private int height;
        private int width;
        private int depth;
        private string color;
        private bool door;
        private List<Element> elements;

        public Boxe(int height, int width, int depth, string color, bool door)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.color = color;
            this.door = door;
            elements = new List<Element>();
            MessageBox.Show("Casier créé : "+ height.ToString()+"-"+width.ToString() + "-"+ depth.ToString() + " couleur "+color+" portes:"+door.ToString());

            if (door is true) { AddDoor(); }
            // Ajout des 5 Panneaux
            AddPanel();
            // Ajout des 8 Traverses
            AddCleat();
            // Ajout des 4 Tasseaux
            AddCrossbar();
        }


        private void AddDoor()
        {
            // Portes G/D
            Door leftDoor = new Door((width - 4) / 2, height - 4, color);
            Door rightDoor = new Door((width - 4) / 2, height - 4, color);
            elements.Add(leftDoor);
            elements.Add(rightDoor);

        }

        private void AddCleat()
        {
            // 2 Traverses avant
            Cleat TAVB = new Cleat(width - 4, 0, "AV");
            Cleat TAVH = new Cleat(width - 4, 0, "AV");
            // 2 Traverses arrières
            Cleat TARB = new Cleat(width - 4, 0, "AR");
            Cleat TARH = new Cleat(width - 4, 0, "AR");
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
            Panel PH = new Panel(0, depth, width - 4, "HB", color);
            Panel PB = new Panel(0, depth, width - 4, "HB", color);
            Panel PG = new Panel(height - 4, depth, 0, "GD", color);
            Panel PD = new Panel(height - 4, depth, 0, "GD", color);
            Panel PAR = new Panel(height - 4, 0, width - 4, "AR", color);
        }

        public List<Element> GetElem()
        {
            return elements;
        }
    }
}
