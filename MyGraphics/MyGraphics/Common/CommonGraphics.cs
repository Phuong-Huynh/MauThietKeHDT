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
        //Draw
        void DrawLine(Point p1, Point p2);
        void DrawRect(Point p1, int width, int height);
       
        void DrawEllipse(Point p1, int width, int heiht);
       // void DrawString(string str, Font font, Brush brush, Point point);

        //Fill object
        void FillRect(Point p1, int width, int height);
        void setFillColor(Color color);

        //Set size brush
        void setHighlight(int size, Color clolor);
         void FillEllipse(Point p1, int width, int heiht);
         void DrawArc(Point p1, int width, int height, float startAngle, float sweepAngle);
    }
}