using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_KITBOX
{
    class Cleat:Element
    {
        

        public Cleat(int width, int depth,string position)
        {
            this.width = width;
            this.depth = depth;            
            this.position = position;
            this.code = "TR";
            this.nbPerBox = 2;
            SetCode();
        }

        private void SetCode()
        {

            if (depth != 0)
            {
                code += "G" + depth.ToString();
            }

            else if (position == "AR")
            {
                code += "R" + width.ToString();
            }

            else if (position == "AV")
            {
                code += "F" + width.ToString();
            }
        }
       
    }
}
