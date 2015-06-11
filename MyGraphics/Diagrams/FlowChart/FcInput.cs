using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams.ActivityDiagram
{
    class FcInput : Block
    {
        public override Block clone(DiagramFactory f)
        {
            
             return f.createInput(this.info);
        }

        public override void draw(Common.CommonGraphics g)
        {
            // 
        }
    }
}
