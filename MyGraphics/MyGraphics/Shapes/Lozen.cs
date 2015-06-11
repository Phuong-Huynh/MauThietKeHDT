using MyGraphics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyGraphics.Shapes
{
    class Lozen : Shape
    {
        public override void draw(CommonGraphics g)
        {
            //Toa do 4 diem
            Point P1 = new Point(info.p1.X + info.width / 2, info.p1.Y);
            Point P2 = new Point(info.p1.X, info.p1.Y + info.height / 2);
            Point P3 = new Point(info.p1.X + info.width / 2, info.p1.Y + info.height);
            Point P4 = new Point(info.p1.X + info.width, info.p1.Y + info.height / 2);

            //se 4 duong thang
            //g.DrawLine(P1, P2);
            //g.DrawLine(P3, P2);
            //g.DrawLine(P3, P4);
            //g.DrawLine(P1, P4);
        }
    }
}
