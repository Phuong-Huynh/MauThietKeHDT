using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyGraphics.Diagrams.ActivityDiagram
{
    class FcEnd :Block
    {
        public override Block clone(DiagramFactory f)
        {
            throw new NotImplementedException();
        }

        public override void draw(Common.CommonGraphics g)
        {
            g.DrawEllipse(new Point(Info.p1.X, Info.p1.Y), Info.width, Info.height); // ve ellip
            SolidBrush sb = new SolidBrush(Color.Black);

            // truyen chuoi vo
        }
    }
}
