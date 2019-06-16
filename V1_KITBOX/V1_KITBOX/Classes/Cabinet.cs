    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1_KITBOX
{
    public class Cabinet
    {
        private List<Boxe> boxes;
        private int height;
        private int width;
        private int depth;
       
        private Corner corner;

        public Cabinet(int depth , int width, int height , string corner_color)
        {
            this.width = width;
            this.depth = depth;
            this.height = height;
            this.corner = new Corner(height, corner_color);
            boxes = new List<Boxe>();
            MessageBox.Show("Votre armoire est ajouté au panier :\nProfondeur : " + depth.ToString() + "\nLargeur : "+width.ToString()+"\nHauteur : "+height.ToString(), "Bravo !");
        }

        public void AddBox(int height, int width, int depth, string color, bool door, string door_color)
        {
            this.boxes.Add(new Boxe(height, width, depth, color, door, door_color));
        }
    

        public void removeAllBoxes()
        {
            this.boxes.Clear();
        }

        public List<Boxe> GetBoxes { get { return boxes; } }
        public Boxe getLastBox() { return boxes[boxes.Count - 1]; }
        public int GetHeight() { return height; }
        public int GetWidth() { return width; }
        public int GetDepth(){ return depth; }
        public Corner GetCorner() { return corner; }
        public int GetNumberBoxes()
        {
            int n = boxes.Count;
            return n;
        }
        
        


    }
}
