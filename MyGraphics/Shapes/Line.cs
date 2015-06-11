using MyGraphics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Shapes
{
    class Line : Shape
    {
        public override void draw(CommonGraphics g)
        {
            g.DrawLine(Info.p1, Info.p2);
        }
    }
}
