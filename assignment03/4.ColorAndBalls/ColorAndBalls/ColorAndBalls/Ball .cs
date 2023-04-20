using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorAndBalls
{
    class Ball
    {
        public int size { get; set; }
        public Color color { get; set; }
        public int numThrows { get; set; }

        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
            numThrows = 0;
        }

        public void Throw()
        {
            if (size != 0)
            {
                numThrows++;
            }
        }
        public void Pop()
        {
            size = 0;
        }

    }
}
