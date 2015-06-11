using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyGraphics.Decorator
{
    class HighlightShape : EffectedShape
    {
        protected override void format(Common.CommonGraphics g, Shapes.Shape shape)
        {
            g.setHighlight(30, Color.Pink);
            shape.draw(g);
            g.setHighlight(1, shape.Info.color);
        }
    }
}
