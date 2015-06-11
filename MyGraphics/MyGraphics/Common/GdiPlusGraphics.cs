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
        }


        public void DrawEllipse(Point p1, int width, int heiht)
        {
            lib.DrawEllipse(pen, p1.X, p1.Y, width, heiht);
        }

        #endregion
    }
}
