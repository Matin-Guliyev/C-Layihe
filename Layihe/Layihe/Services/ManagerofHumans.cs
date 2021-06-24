using Layihe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layihe.Services
{
    class ManagerofHumans : IHumanResourceManager
    {
        public void AddDepartment(string name, int workerlimit, double salarylimit)
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(string fullname, double salary, string Departamentname)
        {
            throw new NotImplementedException();
        }

        public void EditDepartment(string name, string newName)
        {
            throw new NotImplementedException();
        }

        public void EditEmployee(string no, string name, string surname, double salary, string position)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemovEmployee(string no, string departmentname)
        {
            throw new NotImplementedException();
        }
    }
}
