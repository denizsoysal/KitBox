using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_KITBOX
{
    class Crossbar : Element
    {
        public Crossbar(int height)
        {
            this.height = height;
            this.code = "TAS" + (height - 5).ToString();
        }
    }
}
