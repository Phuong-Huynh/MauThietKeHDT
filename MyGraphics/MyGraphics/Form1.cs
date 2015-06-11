using MyGraphics.Common;
using MyGraphics.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyGraphics
{
    public partial class Form1 : Form
    {
        Point p1, p2;
        Boolean isMouseDown = false;
        Graphics gGDI;
        Color c;
        Pen pen, eraser;

        ShapeTypes ShapeType;

        CommonGraphics graphics;
        public Form1()
        {
            InitializeComponent();
            gGDI = pnlPaint.CreateGraphics();
            pen = new Pen(Color.Black);
            //eraser = new Pen(pnlPaint.BackColor);
            graphics = new GdiPlusGraphics(gGDI, pen);
            ShapeType = ShapeTypes.LINE;
        }


        private void pnlPaint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                p1 = new Point(e.X, e.Y);
            }


        }

        private void pnlPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                //if (p2 != null)
                //    g.DrawLine(eraser, p1, p2);
                //p2 = new Point(e.X, e.Y);
                //g.DrawLine(pen, p1, p2);

            }
        }

        private void pnlPaint_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown && e.Button == MouseButtons.Left)
            {
                p2 = new Point(e.X, e.Y);
                switch (ShapeType)
                {
                    case ShapeTypes.LINE:
                        Line line = new Line();
                        line.Info = new ShapeInfo
                        {
                            p1 = p1,
                            p2 = p2,
                            color = Color.Black,
                        };
                        line.draw(graphics);
                        break;

                    case ShapeTypes.RECT:
                        Rect rect = new Rect();
                        rect.Info = new ShapeInfo
                        {
                            p1 = p1,
                            width = Math.Abs(p1.X - p2.X),
                            height = Math.Abs(p1.Y - p2.Y),
                            color = Color.Black,
                        };
                        rect.draw(graphics);
                        break;

                    case ShapeTypes.ELLIPSE:
                        Ellipse ellipse = new Ellipse();
                        ellipse.Info = new ShapeInfo
                        {
                            p1 = p1,
                            width = Math.Abs(p1.X - p2.X),
                            height = Math.Abs(p1.Y - p2.Y),
                            color = Color.Black,
                        };
                        ellipse.draw(graphics);
                        break;

                    case ShapeTypes.LOZEN:
                        Lozen lozen = new Lozen();
                        lozen.Info = new ShapeInfo
                        {
                            p1 = p1,
                            width = Math.Abs(p1.X - p2.X),
                            height = Math.Abs(p1.Y - p2.Y),
                            color = Color.Black,
                        };
                        lozen.draw(graphics);
                        break;
                    default:
                        break;
                }


            }

        }

        private void rdbLine_CheckedChanged(object sender, EventArgs e)
        {
            ShapeType = ShapeTypes.LINE;
        }

        private void rdbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            ShapeType = ShapeTypes.RECT;
        }

        private void rdbEllipse_CheckedChanged(object sender, EventArgs e)
        {
            ShapeType = ShapeTypes.ELLIPSE;
        }

        private void rdbLozenge_CheckedChanged(object sender, EventArgs e)
        {
            ShapeType = ShapeTypes.LOZEN;
        }
    }
}
