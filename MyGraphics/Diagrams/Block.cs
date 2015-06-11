using MyGraphics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams
{
    public abstract class Block : Shape
    {
        public abstract Block clone(DiagramFactory f);
    }
}
