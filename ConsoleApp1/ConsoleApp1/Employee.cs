using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        protected long empNum;
        protected long empSal;
        public long EmpNum
        {
            get
            {
                return empNum;
            }
            set
            {
                empNum = value;
            }
        }
        public long EmpSal
        {
            get
            {
                return empSal;
            }
            set
            {
                empSal = value;
            }
        }

    }
}
