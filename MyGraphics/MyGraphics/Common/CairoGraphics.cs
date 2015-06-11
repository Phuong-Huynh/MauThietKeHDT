using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cairo;

namespace MyGraphics.Common
{
    public class CairoGraphics : CommonGraphics
    {
        Context lib;
        Surface s;

        public CairoGraphics(System.Drawing.Graphics g)
        {
            s = new Win32Surface(g.GetHdc());
            lib = new Context(s);
        }

        #region CommonGraphics Members

        public void DrawLine(System.Drawing.Point p1, System.Drawing.Point p2)
        {
            lib.MoveTo((double)p1.X, (double)p1.Y);
            lib.LineTo((double)p1.X, (double)p1.Y);
            lib.Stroke();
        }

        public void DrawRect(System.Drawing.Point p1, int width, int height)
        {
            lib.Rectangle((double)p1.X, (double)p1.Y, (double)width, (double)height);
        }

        public void DrawEllipse(System.Drawing.Point p1, int width, int heiht)
        {
            throw new NotImplementedException();
        }

        #endregion


        public void FillRect(System.Drawing.Point p1, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void setFillColor(System.Drawing.Color color)
        {
            throw new NotImplementedException();
        }


        public void setHighlight(int size, System.Drawing.Color clolor)
        {
            throw new NotImplementedException();
        }
    }
}
