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
        private string corner_color;

        public Cabinet(int depth , int width, string corner_color)
        {
            this.width = width;
            this.depth = depth;
            this.corner_color = corner_color;
            boxes = new List<Boxe>();
            MessageBox.Show("Une armoire à été crée aux dimensions :" + depth.ToString() + "-"+width.ToString()+" couleur "+corner_color);
        }

        public void AddBox(int height, int width, int depth, string color, bool door, string door_color)
        {
            this.boxes.Add(new Boxe(height, width, depth, color, door, door_color));
        }

        public void removeAllBoxes()
        {
            this.boxes.Clear();
        }

        public List<Boxe> getboxes { get { return boxes; } }
        public Boxe getLastBox() { return boxes[boxes.Count - 1]; }
        public int GetHeight() { return height; }
        public int GetWidth() { return width; }
        public int GetDepth(){ return depth; }
        public string GetCornerColor() { return corner_color;}
        // Write an "Add" function to add a new box in the box list
        
        public void SetHeight(int height) { this.height = height;}

    }
}
