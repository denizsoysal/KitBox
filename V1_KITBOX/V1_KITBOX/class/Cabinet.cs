    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_KITBOX
{
    public class Cabinet
    {
        private List<Boxe> boxes;
        private int height;
        private int width;
        private int depth;
        private string corner_color;
        private string angleIron;
        public Cabinet(int depth , int width, string corner_color)
        {
            this.width = width;
            this.depth = depth;
            this.corner_color = corner_color;
            boxes = new List<Boxe>();
        }
        public int GetHeight() { return height; }
        public int GetWidth() { return width; }
        public int GetDepth(){ return depth; }
        public string GetCornerColor() { return corner_color;}
        // Write an "Add" function to add a new box in the box list
        
        public void SetHeight(int height) { this.height = height;}

    }
}
