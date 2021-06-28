using Layihe.Interfaces;
using Layihe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layihe.Services
{
    public class ManagerofHumans : IHumanResourceManager //implement the Interface and write the interface body in this class...
        //and all method in managerofHuman class...
    {
        public List<Department> Departments { get; set; }
        public List<Employee> Employees { get; set; }

        public ManagerofHumans()
        {
            Departments = new List<Department>();
            Employees = new List<Employee>();
        }
        public void AddDepartment(string name, int workerlimit, double salarylimit)// using isNullorEmpty //using type of exception    
        {
            Department department = new Department(name, workerlimit, salarylimit);
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name is empty");
            if (workerlimit <= 0)
                throw new ArgumentNullException("Worker limit is less than zero");
            if (salarylimit <= 250)
                throw new ArgumentNullException("salarylimit is less than  250");
            Departments.Add(department);
        }
        public void AddEmployee(string fullname , string position, double salary, string departmentname)
        {
            Employee employee = new Employee(fullname, departmentname, position, salary);
            if (string.IsNullOrEmpty(fullname))
                throw new ArgumentNullException(" name can not be empty or null");
            if (string.IsNullOrEmpty(position))
                throw new ArgumentNullException("Position can not be empty or null");
            if (salary < 250)
                throw new ArgumentOutOfRangeException("Salary can not be less than 250 AZN");
            if (string.IsNullOrEmpty(departmentname))
                throw new ArgumentNullException("Department name can not be empty or null");
            var department = Departments.Find(s => s.DepartmentName == departmentname);
            if (department == null)
                throw new ArgumentNullException("There is no such department");
            employee.FullName = fullname;
            employee.Position = position;
            employee.Salary = salary;
            employee.DepartmentName = departmentname;
            department.Employees.Add(employee);
        }
        public void EditDepartament(string name, string newName)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(newName))
                throw new ArgumentNullException("Department name can not be empty or null");
            var department = Departments.Find(s => s.DepartmentName == name);
            if (department == null)
                throw new ArgumentNullException("There is no such department");
            department.DepartmentName = newName;
        }
        public void EditEmployee(string no, string fullname, double salary, string position)
        {
            if (salary <= 250)
                throw new ArgumentOutOfRangeException("salary is less than 250");
            object employeetemp = null;
            foreach (var department in Departments)
            {
                var employee = department.Employees.Find(s => s.No == no);
                employeetemp = employee;
                if (employee != null)
                {
                    employee.FullName = fullname;
                    employee.Position = position;
                    employee.Salary = salary;
                }
            }
            if (employeetemp == null)
                throw new KeyNotFoundException("There is no such employee with a given ID");
        }
        public List<Department> GetDepartments()
        {
            if (Departments.Count == 0)
                throw new KeyNotFoundException("List is empty");
            return Departments.ToList();
        }
        public void RemoveEmployee(string no, string departmentname)
        {
            if (string.IsNullOrEmpty(no))
                throw new ArgumentNullException("ID can not be empty or null");
            List<int> tempcheck = new List<int>() { };
            foreach (var item in Departments)
            {
                int index = item.Employees.FindIndex(s => s.No == no && s.DepartmentName == departmentname);
                tempcheck.Add(index);
                if (index > -1)
                {
                    item.Employees.RemoveAt(index);
                }
            }
            if (tempcheck.Sum() / tempcheck.Count == -1)
            {
                throw new KeyNotFoundException("There is no such employee with a given no");
            }
            RemoveEmployee(no, departmentname);
        }

       public List<Employee> GetEmployees()
       {
            List<Employee> Temp = new List<Employee>();
            foreach (var item in Departments) 
            {
                foreach (var item1 in item.Employees)
                {
                    Temp.Add(item1);
                }
            }
            if (Temp.Count == 0)
                throw new KeyNotFoundException("List is empty");
            return Temp.ToList();
       }
        public List<Employee>GetEmployeesByDepartment(string departmentname)
        {
            var department = Departments.Find(a => a.DepartmentName == departmentname);
            if (department == null)
                throw new ArgumentNullException("There is no such department!");
            return department.Employees.ToList();
        }

        public void EditDepartment(string name, string newName)
        {
            throw new NotImplementedException();
        }

        public void RemovEmployee(string no, string departmentname)
        {
            throw new NotImplementedException();
        }
    }
}
