using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams.ActivityDiagram
{
    class AcTransition : Block
    {
        public override Block clone(DiagramFactory f)
        {
            return f.createTransition(this.info);
        }

        public override void draw(Common.CommonGraphics g)
        {
            g.DrawLine(info.p1, info.p2);
        }
    }
}
