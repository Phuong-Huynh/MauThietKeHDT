using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyGraphics.Common
{
    public class GdiPlusGraphics : CommonGraphics
    {
       
        protected Graphics lib;

        protected Pen pen;
        protected SolidBrush brush = new SolidBrush(Color.Black);

        public void setFillColor(Color color) {
            brush.Color = color;
        }

        public Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }

        public GdiPlusGraphics(Graphics g)
        {
            this.lib = g;
        }

        public GdiPlusGraphics(Graphics g, Pen pn)
        {
            this.lib = g;
            this.pen = pn;
        }

        #region CommonGraphics Members

        public void DrawLine(Point p1, Point p2)
        {
            lib.DrawLine(pen, p1, p2);
        }

        public void DrawRect(Point p1, int width, int height)
        {
            lib.DrawRectangle(pen, p1.X, p1.Y, width, height);
            lib.Save();
        }


        public void DrawEllipse(Point p1, int width, int heiht)
        {
            lib.DrawEllipse(pen, p1.X, p1.Y, width, heiht);
        }

        public void FillRect(Point p1, int width, int height) 
        {
            lib.FillRectangle(brush, p1.X, p1.Y, width, height);
        }

        #endregion


        public void setHighlight(int size, Color color)
        {
            pen.Width = size;
            pen.Color = color;
        }

        


        public void FillEllipse(Point p1, int width, int heiht)
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            lib.FillEllipse(sb, p1.X, p1.Y, width, heiht);
        }

        public void DrawArc(Point p1, int width, int height, float startAngle, float sweepAngle)
        {
            lib.DrawArc(pen, p1.X, p1.Y, width, height, startAngle, sweepAngle);
        }
        public void DrawString(string str,Font font,Brush brush, Point point  )
        {
            lib.DrawString(str, font, brush, point);
        }
    }
}
