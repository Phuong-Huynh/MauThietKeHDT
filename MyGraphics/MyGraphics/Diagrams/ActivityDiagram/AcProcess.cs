using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams.ActivityDiagram
{
    class AcProcess : Block
    {
        public override Block clone(DiagramFactory f)
        {
            throw new NotImplementedException();
        }

        public override void draw(Common.CommonGraphics g)
        {
            int a;
            if (info.width < info.height)
                a = info.width * 1 / 6;
            else
                a = info.height * 1 / 6;


            g.DrawLine(new Point(Info.p1.X + a, info.p1.Y), new Point(info.p1.X + info.width - a, info.p1.Y));//canh tren
            g.DrawLine(new Point(Info.p1.X, info.p1.Y + a), new Point(info.p1.X, info.p1.Y + info.height - a));// trai

            g.DrawLine(new Point(info.p1.X + a, info.p1.Y + info.height), new Point(info.p1.X + info.width - a, info.p1.Y + info.height)); //duoi
            g.DrawLine(new Point(info.p1.X + info.width, info.p1.Y + a), new Point(info.p1.X + info.width, info.p1.Y + info.height - a)); //phai


            g.DrawArc(info.p1, 2 * a, 2 * a, 180, 90); //cung tron tren trai
            g.DrawArc(new Point(info.p1.X + info.width - 2 * a, info.p1.Y), 2 * a, 2 * a, 270, 90); // cung tron tren phai
            g.DrawArc(new Point(info.p1.X, info.p1.Y + info.height - 2 * a), 2 * a, 2 * a, 90, 90); // cung tron duoi tra
            g.DrawArc(new Point(info.p1.X + info.width - 2 * a, info.p1.Y + info.height - 2 * a), 2 * a, 2 * a, 0, 90); // cung tron duoi phai
        }
    }
}
