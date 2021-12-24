using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    interface IHumanResourceManager
    {
        public string Departments { get; set; }
        void AddDepartment();
        void GetDepartments();
        void EditDepartaments();
        void AddEmployee();
        void RemoveEmployee();
        void EditEmploye();
    }
}
