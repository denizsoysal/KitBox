using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_KITBOX
{
    public abstract class Element
    {
       protected string code;       
       protected int height;
       protected int depth;
       protected int width;
       protected string position;
       protected string color;
    
       public string GetCode(){ return code; }
       public int GetHeight(){ return height; }
       public int GetDepth(){ return height; }
       public int GetWidth(){ return width; }
       public string GetColor() { return color; }

    }
}
