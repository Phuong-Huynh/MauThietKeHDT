using MyGraphics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams
{
    public interface DiagramFactory
    {
        Block createStart(ShapeInfo info);
        Block createInput(ShapeInfo info);
        Block createProcess(ShapeInfo info);
        Block createOutput(ShapeInfo info);
        Block createTransition(ShapeInfo info);
        Block createCondition(ShapeInfo info);
        Block createEnd(ShapeInfo info);
        
    }
}
