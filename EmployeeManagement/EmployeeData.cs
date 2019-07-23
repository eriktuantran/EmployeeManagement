using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class EmployeeData
    {
        public bool exist = false;
        public string empId = "";
        public string firstName = "";
        public string lastName = "";
        public string deptId = "";
        public string deptStr = "";

        public string getEmployeeName()
        {
            return lastName + " " + firstName; 
        }

        public void dump()
        {
            Console.WriteLine("DUMP contact data##############");
            Console.WriteLine(exist);
            Console.WriteLine(empId);
            Console.WriteLine(firstName + "" + lastName);
            Console.WriteLine(deptId + deptStr);
            Console.WriteLine("##############");

        }
    }
}
