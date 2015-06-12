using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams.ActivityDiagram
{
    class FcProcess : Block
    {
        public override Block clone(DiagramFactory f)
        {
            throw new NotImplementedException();
        }

        public override void draw(Common.CommonGraphics g)
        {
            g.DrawRect(Info.p1, Info.width, Info.height);
        }
    }
}
