using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layihe
{
    class Employee
    {
        public string FullName;
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public string Position { get; set; }
        public string DepartmentName { get; set; }
        public Employee(string name, string surname, string departmentname, string position, double salary)
        {
            Surname = surname;
            Name = name;
            FullName = Name + " " + Surname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentname;
            No = departmentname.ToString().Trim().ToUpper().Substring(0, 2) + TotalCount.ToString(); 

        }
        public double Salary = 250;
        public string No { get; set; }
        public static int TotalCount = 1000;
         
        public Employee()
        {
            TotalCount++;
        }

        public override string ToString()
        {
            return $"{FullName} {Salary} {DepartmentName} {Position} {No}";
        }

    }
}
