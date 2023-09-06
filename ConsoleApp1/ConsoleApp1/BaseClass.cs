using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BaseClass
    {
        public virtual string show()
        {
            return "We are in BaseClass.";
        }
        public string display()
        {
            return "We are in BaseClass display.";
        }
    }
}
