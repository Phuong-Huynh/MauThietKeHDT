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
            g.DrawEllipse(new Point(Info.p1.X, Info.p1.Y),Info.width,Info.height); // ve ellip

            
            // truyen chuoi vo
           // Font f = new Font("Arial", 30);
          //  SolidBrush s = new SolidBrush(Color.Black);
         //   g.DrawString("Start", f, s, new Point(Info.p1.X, Info.p1.Y));


        }
    }
}
