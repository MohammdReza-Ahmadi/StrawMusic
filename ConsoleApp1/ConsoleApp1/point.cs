using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class point : Shape
    {
        private int x;
        private int y;
        public point()
        {

        }
        public point(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public override string ToString()
        {
            return "[" + x + "," + Y + "]";
        }
        public override string Name
        {
            get
            {
                return "point";
            }
        }
    }
}
