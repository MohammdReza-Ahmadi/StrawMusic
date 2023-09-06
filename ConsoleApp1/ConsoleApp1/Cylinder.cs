using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cylinder : Circle
    {
        private double height;
        public Cylinder()
        {

        }
        public Cylinder(int xValue, int yValue, double radiusValue, double heightValue) : base(xValue, yValue, radiusValue)
        {
            Height = heightValue;
        }
        public override double area()
        {
            return 2 * base.area() + base.Circumference() * Height;
        }
        public override double volume()
        {
            return base.area() * Height;
        }
        public override string ToString()
        {
            return base.ToString() + ", Height = " + Height;
        }
        public override string Name
        {
            get
            {
                return "Cylindeer";
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >= 0)
                    height = value;
            }
        }
    }
}
