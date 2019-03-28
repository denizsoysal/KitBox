using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_KITBOX
{
    class Panel : Element
    {
        public Panel(int height, int depth, int width, string position, string color)
        {
            this.height = height;
            this.depth = depth;
            this.width = width;
            this.position = position;
            this.color = color;
            SetCode();
        }

        private void SetCode()
        {
            code = "PA";

            if (position == "AR") { code += "R"; }

            else if (position == "GD") { code += "G"; }

            else if (position == "HB") { code += "H"; }

            code += height.ToString() + width.ToString() + char.ToUpper(color[0]) + char.ToUpper(color[1]);
        }
    }
}
