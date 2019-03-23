using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_KITBOX
{
    class Door : Element
    {
        public Door(int width, int height, string color)
        {
            this.width = width;
            this.height = height;
            this.color = color;
            SetCode();
        }

        public void SetCode()
        {
            code = "POR" + height.ToString() + width.ToString();

            if (color == "Blanc") { code += "BL"; }

            else if (color == "Brun") { code += "BR"; }

            else { code += "VE"; }

        }
    }
}
