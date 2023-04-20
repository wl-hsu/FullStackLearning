using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorAndBalls
{
    class Color
    {
        public byte red { get; set; }
        public byte green { get; set; }
        public byte blue { get; set; }
        public byte alpha { get; set; }

        //Color constructor
        public Color(byte red, byte green, byte blue, byte alpha = 255)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        //get the grayscale value
        public double GetGrayScaleValue()
        {
            return (red + green + blue)  / 3;
        }
    }
}
