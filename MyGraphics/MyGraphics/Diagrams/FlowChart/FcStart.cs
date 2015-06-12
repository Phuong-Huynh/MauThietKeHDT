using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams.ActivityDiagram
{
    class FcStart : Block
    {
        public override Block clone(DiagramFactory f)
        {
            throw new NotImplementedException();
        }

        public override void draw(Common.CommonGraphics g)
        {
            g.DrawEllipse(new Point(Info.p1.X, Info.p1.Y), Info.width, Info.height); // ve ellip
        }
    }
}
