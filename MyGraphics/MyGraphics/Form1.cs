using MyGraphics.Common;
using MyGraphics.Decorator;
using MyGraphics.Diagrams.ActivityDiagram;
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
        System.Drawing.Point p1, p2;
        Boolean isMouseDown = false;
        System.Drawing.Graphics gContext, gContext2;
        System.Drawing.Color c;
        Pen pen, eraser;

        ShapeTypes shapeType;
        GraphicsTypes graphicsType;

        CommonGraphics graphics;
        GdiPlusGraphics gdiGraphics;
        CairoGraphics cairogGraphics;
        public Form1()
        {
            InitializeComponent();
           
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            gContext = pnlPaint.CreateGraphics();
            gContext2 = pnlPaint.CreateGraphics();
            pen = new Pen(System.Drawing.Color.Black);
            //eraser = new Pen(pnlPaint.BackColor);

            gdiGraphics = new GdiPlusGraphics(gContext, pen);
            cairogGraphics = new CairoGraphics(pnlPaint.CreateGraphics());

            shapeType = ShapeTypes.LINE;
            graphicsType = GraphicsTypes.GDI;
            graphics = gdiGraphics;

            /////------TEST ------ActivityDiagram----------/////
            //acstart
            base.OnPaint(e);
            AcStart acstart = new AcStart();
            acstart.Info = new ShapeInfo
            {
                p1 = new Point(50, 50),
                width = 70,
                height = 70,

            };
            acstart.draw(graphics);
            //acinput (dau vao);
            AcInput acinput = new AcInput();
            acinput.Info = new ShapeInfo
            {
                p1 = new Point(150, 50),
                width = 100,
                height = 70,
            };
            acinput.draw(graphics);
            //acprocess (xu li)
            AcProcess acprocess = new AcProcess();
            acprocess.Info = new ShapeInfo
            {
                p1 = new Point(300, 50),
                width = 100,
                height = 70,
            };
            acprocess.draw(graphics);
            //acOutput (dau ra)
            AcOutput acoutput = new AcOutput();
            acoutput.Info = new ShapeInfo
            {
                p1 = new Point(450, 50),
                width = 100,
                height = 70,
            };
            acoutput.draw(graphics);
            //acTransittion
            AcTransition actransition = new AcTransition();
            actransition.Info = new ShapeInfo
            {
                p1 = new Point(50, 150),
                p2 = new Point(100, 200),
            };
            actransition.draw(graphics);

            //acCondition (dieu kien)
            AcCondition accondition = new AcCondition();
            accondition.Info = new ShapeInfo
            {
                p1 = new Point(300, 150),
                width = 100,
                height = 70,
            };
            accondition.draw(graphics);
            //AcEnd (ket thuc)
            AcEnd acend = new AcEnd();
            acend.Info = new ShapeInfo
            {
                p1 = new Point(450, 150),
                width = 60,
                height = 60,
            };
            acend.draw(graphics);
            
        }


        private void pnlPaint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                p1 = new System.Drawing.Point(e.X, e.Y);
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
                p2 = new System.Drawing.Point(e.X, e.Y);
                switch (shapeType)
                {
                    case ShapeTypes.LINE:
                        Line line = new Line();
                        line.Info = new ShapeInfo
                        {
                            p1 = p1,
                            p2 = p2,
                            color = System.Drawing.Color.Black,
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
                            color = Color.Yellow,
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
                            color = System.Drawing.Color.White,
                        };
                        //ellipse.draw(graphics);
                        EffectedShape effShapeelipse = new HighlightShape();
                        effShapeelipse.shape = ellipse;
                        effShapeelipse.draw(graphics);
                        break;

                    case ShapeTypes.LOZEN:
                        Lozen lozen = new Lozen();
                        lozen.Info = new ShapeInfo
                        {
                            p1 = p1,
                            width = Math.Abs(p1.X - p2.X),
                            height = Math.Abs(p1.Y - p2.Y),
                            color = System.Drawing.Color.Black,
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
            shapeType = ShapeTypes.LINE;
        }

        private void rdbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            shapeType = ShapeTypes.RECT;
        }

        private void rdbEllipse_CheckedChanged(object sender, EventArgs e)
        {
            shapeType = ShapeTypes.ELLIPSE;
        }

        private void rdbLozenge_CheckedChanged(object sender, EventArgs e)
        {
            shapeType = ShapeTypes.LOZEN;
        }

        private void rdbGDI_CheckedChanged(object sender, EventArgs e)
        {
            graphicsType = GraphicsTypes.GDI;
            graphics = gdiGraphics;
        }

        private void rdbCairo_CheckedChanged(object sender, EventArgs e)
        {
            graphicsType = GraphicsTypes.CAIRO;
            graphics = cairogGraphics;
        }
        
    }
}
