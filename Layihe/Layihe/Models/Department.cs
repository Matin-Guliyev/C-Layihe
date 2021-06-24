using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layihe.Models
{
    class Department
    {
        public string DepartmentName { get; set; }
        public int WorkerLimit { get; set; }
        public double  SalaryLimit { get; set; }
        public IList<Employee> employes { get; set; }
        public Department(string Departmentname, int worklimit, double salarylimit)
        {
            DepartmentName = Departmentname;
            WorkerLimit = worklimit;
            SalaryLimit = salarylimit;
        }
        public Department(Employee employees)
        {

        }
        public double CalcSalaryAverage()
        {
            double average = 0;
            double sum = 0;
            foreach (var item in employes)
            {
                sum += item.Salary;
            }

            average = sum / employes.Count;
            return average;
        }
    }
}
