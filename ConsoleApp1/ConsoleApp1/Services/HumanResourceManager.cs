using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    class HumanResourceManager : IHumanResourceManager
    {
        public Department[] Departments => _Departments;
        private Department[] _Departments;

        public Employee[] Employees => _Employees;
        private Employee[] _Employees;

        public HumanResourceManager()
        {
            _Departments = new Department[0];
            _Employees = new Employee[0];
        }
        public void AddDepartment(string Name)
        {
            Department Department = new Department(Name);
            Array.Resize(ref _Departments, _Departments.Length + 1);
            _Departments[_Departments.Length - 1] = Department;
        }
        public Department GetDepartments()
        {
            Department Departaments = null;
            foreach (Department item in _Departments)
            {
                Departaments = item;
            }
            return Departaments;
        }
        public void EditDepartaments(string oldName, string newName)
        {
            Department department = null;

            foreach (Department item in _Departments)
            {
                if (item.Name == oldName)
                {
                    department = item;
                    break;
                }
            }
            department.Name = newName;
        }
        public void AddEmployee(string fullname,string position,double salary,string departmentname)
        {
            Employee Department = new Employee(fullname,position,salary, departmentname);
            Array.Resize(ref _Employees, _Employees.Length + 1);
            _Employees[_Employees.Length - 1] = Department;
        }
        public void RemoveEmployee(string no,string departmentname)
        {
            for (int i = 0; i < _Employees.Length; i++)
            {
                if(_Employees[i] != null && _Employees[i].No == no && _Employees[i].DepartmentName == departmentname)
                {
                    _Employees[i] = null;
                    return;
                }
            }
        }
        public void EditEmploye(string no, string fullname, string position, double salary)
        {
            Employee Employee = null;
            foreach (Employee item in _Employees)
            {
                if (item != null && item.No == no)
                {
                    Employee = item;
                }
            }
            Employee.FullName = fullname;
            Employee.Position = position;
            Employee.Salary = salary;
        }

    }
}
