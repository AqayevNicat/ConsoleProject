using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Department
    {
        public string Name { get; set; }
        public int WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        public Employee[] Employees { get; set; }

        public double maaslar;
        public int say;

        public Department(string name,int workerlimit,double salarylimit)
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
        }
        public override string ToString()
        {
            return $"Depart Name : {Name}";
        }
        public void CalcSalaryAverage()
        {

        }
    }
}
