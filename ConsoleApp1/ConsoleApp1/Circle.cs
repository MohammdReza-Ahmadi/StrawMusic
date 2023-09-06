using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle : point
    {
        private double radius;
        public Circle()
        {

        }
        public Circle(int xValue, int yValue, double radiusValue) : base(xValue, yValue)
        {
            radius = radiusValue;
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (radius >= 0)
                    radius = value;
            }
        }
        public override double area()
        {
            return 3.14 * Radius * Radius;
        }
        public double diameter()
        {
            return Radius * 2;
        }
        public double Circumference()
        {
            return 3.14 * diameter();
        }
        public override string ToString()
        {
            return "Center = " + base.ToString() + ", Radius =" + Radius;
        }
        public override string Name
        {
            get
            {
                return "Circle";
            }
        }
    }
}
