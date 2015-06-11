using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams.ActivityDiagram
{
    class AcEnd : Block
    {
        public override Block clone(DiagramFactory f)
        {
            throw new NotImplementedException();
        }

        public override void draw(Common.CommonGraphics g)
        {
            g.DrawEllipse(info.p1, info.width, info.height);
            g.FillEllipse(new Point(info.p1.X +info.width/6,info.p1.Y + info.height/6),info.width*4/6,info.height*4/6);
        }
    }
}
