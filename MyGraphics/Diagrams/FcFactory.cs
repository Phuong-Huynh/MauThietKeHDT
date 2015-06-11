using MyGraphics.Diagrams.ActivityDiagram;
using MyGraphics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams
{
    public class FcFactory : DiagramFactory
    {
        public Block createStart(ShapeInfo info)
        {
            Block b = new FcStart();
            b.Info = info;
            return b;
        }
        public Block createInput(ShapeInfo info)
        {
            Block b = new FcInput();
            b.Info = info;
            return b;
        }
        public Block createProcess(ShapeInfo info)
        {
            Block b = new FcProcess();
            b.Info = info;
            return b;
        }
        public Block createOutput(ShapeInfo info)
        {
            Block b = new FcOutput();
            b.Info = info;
            return b;
        }
        public Block createTransition(ShapeInfo info)
        {
            Block b = new FcTransition();
            b.Info = info;
            return b;
        }
        public Block createCondition(ShapeInfo info)
        {
            Block b = new FcCondition();
            b.Info = info;
            return b;
        }
        public Block createEnd(ShapeInfo info)
        {
            Block b = new FcEnd();
            b.Info = info;
            return b;
        }
    }
}
