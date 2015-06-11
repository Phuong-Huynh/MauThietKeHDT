using MyGraphics.Common;
using MyGraphics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyGraphics.Decorator
{
    public abstract class EffectedShape : Shape
    {
        public Shape shape;

        protected abstract void format(CommonGraphics g, Shape shape);

        public override void draw(CommonGraphics g)
        {
            format(g, shape);
            shape.draw(g);
        }
    }
}
