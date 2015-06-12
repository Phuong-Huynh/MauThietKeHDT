using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams.ActivityDiagram
{
    class FcOutput : Block
    {
        public override Block clone(DiagramFactory f)
        {
            throw new NotImplementedException();
        }

        public override void draw(Common.CommonGraphics g)
        {
            g.DrawLine(Info.p1, new Point(info.p1.X + info.width, info.p1.Y));//canh tren
            g.DrawLine(Info.p1, new Point(info.p1.X, info.p1.Y + info.height));// trai

            g.DrawLine(new Point(info.p1.X, info.p1.Y + info.height), new Point(info.p1.X + info.width * 4 / 5, info.p1.Y + info.height)); //duoi
            g.DrawLine(new Point(info.p1.X + info.width, info.p1.Y), new Point(info.p1.X + info.width, info.p1.Y + info.height * 4 / 5)); //phai
            g.DrawLine(new Point(info.p1.X + info.width * 4 / 5, info.p1.Y + info.height), new Point(info.p1.X + info.width, info.p1.Y + info.height * 4 / 5)); //cheo goc
        }
    }
}
