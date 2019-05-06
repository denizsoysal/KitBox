using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_KITBOX
{
    public class Corner
    {
        private int height;
        private string color;
        private string code;
        public Corner(int height, string color)
        {
            this.height = height;
            this.color = color;
            SetCode();
        }
        private void SetCode()
        {

            code = "COR" + height.ToString();
            if (color == "Galvanise")
            {
                code += "GL";
            }
            else
            {
                code += char.ToUpper(color[0]) + char.ToUpper(color[1]);
            }
                      
        }
        public string GetCode() { return code; }
        public string GetColor() { return color; }


    }
}
