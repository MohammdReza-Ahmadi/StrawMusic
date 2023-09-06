using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EmployeeService : Employee
    {
        private int empReg;
        public int EmpReg
        {
            get
            {
                return empReg;
            }
            set
            {
                empReg = value;
            }
        }
    }
}
