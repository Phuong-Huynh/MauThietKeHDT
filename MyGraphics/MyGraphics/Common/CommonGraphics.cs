using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Common
{
    public interface CommonGraphics
    {
        void DrawLine(Point p1, Point p2);
        void DrawRect(Point p1, int width, int height);

        void DrawEllipse(Point p1, int width, int heiht);
         void FillEllipse(Point p1, int width, int heiht);
         void DrawArc(Point p1, int width, int height, float startAngle, float sweepAngle);
    }
}
