using MyGraphics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Shapes
{
    public class Rect : Shape
    {
        public override void draw(CommonGraphics g)
        {
            g.DrawRect(Info.p1, Info.width, Info.height);
           
        }
    }
}
