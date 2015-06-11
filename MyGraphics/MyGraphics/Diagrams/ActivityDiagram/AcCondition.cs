﻿using MyGraphics.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams.ActivityDiagram
{
    class AcCondition : Block 
    {
        public override Block clone(DiagramFactory f)
        {
            throw new NotImplementedException();
        }

        public override void draw(Common.CommonGraphics g)
        {
            Lozen lozen = new Lozen();
            lozen.Info = this.Info;
            lozen.draw(g);
            
        }
    }
}
