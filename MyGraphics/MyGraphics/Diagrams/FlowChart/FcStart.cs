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

            SolidBrush color = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 20);
            //g.DrawString("Start", f, color, Info.p1);
            g.DrawString("Start", f, color, new Point(Info.p1.X + Info.height / 4, Info.p1.Y + Info.height / 4));

        }
    }
}
