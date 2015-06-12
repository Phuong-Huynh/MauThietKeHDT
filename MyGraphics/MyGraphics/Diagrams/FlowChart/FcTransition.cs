using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams.ActivityDiagram
{
    class FcTransition : Block
    {
        public override Block clone(DiagramFactory f)
        {
            throw new NotImplementedException();
        }

        public override void draw(Common.CommonGraphics g)
        {
            g.DrawLine(Info.p1, Info.p2);
            if (Info.p1.X == Info.p2.X)
            {
                g.DrawLine(Info.p2, new Point(Info.p2.X - 5, Info.p2.Y - 5));
                g.DrawLine(Info.p2, new Point(Info.p2.X + 5, Info.p2.Y - 5));
            }
            else
            {
                g.DrawLine(Info.p2, new Point(Info.p2.X - 5, Info.p2.Y - 5));
                g.DrawLine(Info.p2, new Point(Info.p2.X - 5, Info.p2.Y + 5));
            }
            
        }
    }
}
