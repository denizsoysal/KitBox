using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_KITBOX
{
    class Cleat : Element
    {


        public Cleat(int width, int depth, string position)
        {
            this.width = width;
            this.depth = depth;
            this.position = position;
            this.code = "TR";
            SetCode();
        }

        private void SetCode()
        {

            if (width == 0)
            {
                code += "G" + depth.ToString();
            }

            else
            {
                if (position == "AR")
                {
                    code += "R" ;
                }
                if (position == "AV")
                {
                    code += "F" ;
                }
                code += width.ToString();
            }
        }

    }
}
