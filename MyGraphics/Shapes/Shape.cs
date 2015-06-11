using MyGraphics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Shapes
{
    public abstract class Shape
    {
        protected ShapeInfo info;

        public ShapeInfo Info
        {
            get { return info; }
            set { info = value; }
        }
        public abstract void draw(CommonGraphics g);
    }
}
