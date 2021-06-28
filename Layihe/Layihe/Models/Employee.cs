using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layihe
{
    public class Employee
    {
        public string FullName { get; set; }       
        public string Position { get; set; }
        public string DepartmentName { get; set; }

        public Employee(string fullname, string departmentname, string position, double salary)
        {

            FullName = fullname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentname;
            TotalCount++;
            No = departmentname.ToString().Trim().ToUpper().Substring(0, 2) + TotalCount.ToString(); 

        }
        public double Salary { get; set; }
        public string No { get; set; }
        public static int TotalCount = 1000;
         
        

        public override string ToString()
        {
            return $"Name  and Surname:{FullName} /   Salary:{Salary}/    DepartmentName:{DepartmentName}/    " +
                $"  Position:{Position}/      No:{No}";
        }

    }
}
