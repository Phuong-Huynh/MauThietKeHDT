using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyGraphics.Decorator
{
    class ShadowShape : EffectedShape
    {
        protected override void format(Common.CommonGraphics g, Shapes.Shape shape)
        {
            g.setFillColor(Color.Black);
            int temp = (shape.Info.width + shape.Info.width) / 12;
            shape.Info.p1.X += temp;
            shape.Info.p1.Y += temp;
            shape.draw(g);
            g.setFillColor(shape.Info.color);
            shape.Info.p1.X -= temp;
            shape.Info.p1.Y -= temp;
        }

        
    }
}