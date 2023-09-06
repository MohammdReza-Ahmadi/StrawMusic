using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public abstract class Shape
    {
        public virtual double area()
        {
            return 0;
        }
        public virtual double volume()
        {
            return 0;
        }
        public abstract string Name
        {
            get;
        }
    }
}
