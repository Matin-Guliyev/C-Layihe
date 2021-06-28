using Layihe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layihe.Interfaces
{
    interface IHumanResourceManager
    {
       void AddDepartment(string name, int workerlimit, double salarylimit);
        void EditDepartment(string name, string newName);
        List<Department> GetDepartments();
        void AddEmployee(string fullname, string position, double salary, string Departamentname);
        void EditEmployee(string no, string fullname, double salary, string position);
        void RemovEmployee(string no, string departmentname);



    }
}
