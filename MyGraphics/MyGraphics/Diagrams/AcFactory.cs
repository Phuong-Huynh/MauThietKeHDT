using MyGraphics.Diagrams.ActivityDiagram;
using MyGraphics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams
{
    class AcFactory : DiagramFactory
    {
        public Block createStart(ShapeInfo info)
        {
            Block b = new AcStart();
            b.Info = info;
            return b;
        }
        public Block createInput(ShapeInfo info)
        {
            Block b = new AcInput();
            b.Info = info;
            return b;
        }
        public Block createProcess(ShapeInfo info)
        {
            Block b = new AcProcess();
            b.Info = info;
            return b;
        }
        public Block createOutput(ShapeInfo info)
        {
            Block b = new AcOutput();
            b.Info = info;
            return b;
        }
        public Block createTransition(ShapeInfo info)
        {
            Block b = new AcTransition();
            b.Info = info;
            return b;
        }
        public Block createCondition(ShapeInfo info)
        {
            Block b = new AcCondition();
            b.Info = info;
            return b;
        }
        public Block createEnd(ShapeInfo info)
        {
            Block b = new AcEnd();
            b.Info = info;
            return b;
        }
        
    }
}
