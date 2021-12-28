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
        public static int WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }

        public Employee[] Employese = {};



        public Department(string name, int workerlimit, double salarylimit, Employee[] employese)
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
            Employese = employese;
        }
        public override string ToString()
        {
            return $"Departamentin adi : {Name}\n" +
                $"Iscilerin sayi : {Employese.Length}\n---------------";
        }
    }
}
