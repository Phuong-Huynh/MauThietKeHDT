using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyGraphics.Diagrams.ActivityDiagram
{
    class FcInput : Block
    {
        public override Block clone(DiagramFactory f)
        {
            throw new NotImplementedException();
        }

        public override void draw(Common.CommonGraphics g)
        {
            g.DrawLine(Info.p1, new Point(Info.p1.X + Info.height / 2, Info.p1.Y - Info.height));
            g.DrawLine(Info.p1, new Point(Info.p1.X + Info.width, Info.p1.Y));
            g.DrawLine(new Point(Info.p1.X + Info.height / 2, Info.p1.Y - Info.height), new Point(Info.p1.X + Info.height / 2 + Info.width, Info.p1.Y - Info.height));
            g.DrawLine(new Point(Info.p1.X + Info.height / 2 + Info.width, Info.p1.Y - Info.height), new Point(Info.p1.X + Info.width, Info.p1.Y));
        }
    }
}
