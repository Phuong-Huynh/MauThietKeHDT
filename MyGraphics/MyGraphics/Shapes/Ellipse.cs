using MyGraphics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Shapes
{
    public class Ellipse : Shape
    {
        public override void draw(CommonGraphics g)
        {
            g.DrawEllipse(info.p1, info.width, info.height);
            
        }
    }
}
