using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_KITBOX
{
    public class Cabinet
    {
        private List<Boxe> boxe;
        private int height;
        private int width;
        private int depth;
        private string corner_color;
        public Cabinet(int depth , int width, string corner_color)
        {
            this.width = width;
            this.depth = depth;
            this.corner_color = corner_color;
            boxe = new List<Boxe>();
        }
        public int GetHeight() { return height; }
        public int GetWidth() { return width; }
        public int GetDepth(){ return depth; }
        public string GetCornerColor() { return corner_color;}
        
        public void SetHeight(int height) { this.height = height;}

    }
}
