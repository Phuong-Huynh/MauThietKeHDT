
using MyGraphics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphics.Diagrams
{
    public class Diagram
    {
        private List<Block> listBlock;
        private DiagramFactory factory;

        public Diagram(DiagramFactory f)
        {
            this.factory = f;
        }

        public void draw(CommonGraphics g)
        {
            foreach (Block b in listBlock)
            {
                b.draw(g);
            }
        }

        public void convert(DiagramFactory f)
        {
            //
        }
    }
}
