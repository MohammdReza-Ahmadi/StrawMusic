using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DerivedClass:BaseClass
    {
        public override string show()
        {
            return "We are in DerivedClass";
        }
        public new string display()
        {
            string t;
            t = base.display();
            return "We are in DerivedClass" + t;
        }
    }
}
