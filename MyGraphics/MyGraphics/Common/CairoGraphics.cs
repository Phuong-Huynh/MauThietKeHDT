using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cairo;
using System.Windows.Forms;
using System.Drawing;

namespace MyGraphics.Common
{
    public class CairoGraphics : CommonGraphics
    {
        protected Context lib;
        protected Surface s;
        

        public CairoGraphics(System.Drawing.Graphics g)
        {
            s = new Win32Surface(g.GetHdc());
            lib = new Context(s);
        }

        #region CommonGraphics Members

        public void DrawLine(System.Drawing.Point p1, System.Drawing.Point p2)
        {
            lib.MoveTo((double)p1.X, (double)p1.Y);
            lib.LineTo((double)p2.X, (double)p2.Y);
            lib.Stroke();
        }

        public void DrawRect(System.Drawing.Point p1, int width, int height)
        {
            lib.Rectangle((double)p1.X, (double)p1.Y, (double)width, (double)height);
            lib.Stroke();
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


        public void FillEllipse(System.Drawing.Point p1, int width, int heiht)
        {
            throw new NotImplementedException();
        }

        public void DrawArc(System.Drawing.Point p1, int width, int height, float startAngle, float sweepAngle)
        {
            throw new NotImplementedException();
        }
        public void DrawString(string str, Font font, Brush brush, System.Drawing.Point point)
        {
            
            
            
        }
    }
}
