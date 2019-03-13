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

        public Boxe(int height, int width, int depth, string color, bool door)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.color = color;
            this.door = door;

        }
    }
}
