﻿using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    class HumanResourceManager : IHumanResourceManager
    {
        public static int EmployeeCount = 0;
        public Department[] Departments => _Departments;
        private Department[] _Departments;

        public Employee[] Employees => _Employees;
        private Employee[] _Employees;

        public HumanResourceManager()
        {
            _Departments = new Department[0];
            _Employees = new Employee[0];
        }
        public void AddDepartment(string Name, int workerlimit, double salarylimit, Employee[] employese)
        {
            Department Department = new Department(Name, workerlimit, salarylimit, employese);
            Array.Resize(ref _Departments, _Departments.Length + 1);
            _Departments[_Departments.Length - 1] = Department;
            foreach (var item in employese)
            {
                if (item != null)
                {
                    Array.Resize(ref _Employees, _Employees.Length + 1);
                    _Employees[_Employees.Length - 1] = item;
                }
               
            }
           
            Department.WorkerLimit--;

        }
        public void GetDepartments() { }
        public void EditDepartaments(string oldName, string newName)
        {
            foreach (Department item in _Departments)
            {
                if (item.Name != null && item.Name == oldName)
                {
                    item.Name = newName;
                }
            }

        }
        public void AddEmployee(string fullname, string position, double salary, string departmentname)
        {
            
            Employee employee = new Employee(fullname, position, salary, departmentname);
            Array.Resize(ref _Employees, _Employees.Length + 1);
            _Employees[_Employees.Length - 1] = employee;
            EmployeeCount++;
            Department.WorkerLimit--;

            foreach (Department item in _Departments)
            {
                if (item != null && employee.DepartmentName.ToLower() == item.Name.ToLower())
                {
                    Array.Resize(ref item.Employese, item.Employese.Length + 1);
                    item.Employese[item.Employese.Length - 1] = employee;
                }
            }
            

        }
        public void GetEmployees()
        {
            //Employee employe = null;
            //foreach (Employee item in _Employees)
            //{
            //    if (item != null)
            //    {
            //        employe = item;
            //        break;
            //    }
            //    employe.No = item.No;
            //    employe.FullName = item.FullName;
            //    employe.Position = item.Position;
            //    employe.Salary = item.Salary;
            //    employe.DepartmentName = item.DepartmentName;
            //}
        }
        public void GetEmployeesByDepartment(string departmentName)
        {

        }
       
        public void RemoveEmployee(string no, string departmentname)
        {
            for (int i = 0; i < _Employees.Length; i++)
            {
                if (_Employees[i] != null && _Employees[i].No.ToLower() == no.ToLower() && _Employees[i].DepartmentName.ToLower() == departmentname.ToLower())
                {
                    Employee.Workercount--;
                    Employee.ortasal -= _Employees[i].Salary;
                    _Employees[i] = null;

                    return;
                }
            }
        }
        public void EditEmploye(string no, string position, double salary)
        {
            foreach (Employee item in _Employees)
            {
                if (item.No.ToLower() == no.ToLower())
                {
                    item.Position = position;
                    item.Salary = salary;
                }
            }
        }
    }
}
