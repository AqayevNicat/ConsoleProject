using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Departament
    {
        public string Name { get; set; }
        public int WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        public Employee[] Employees { get; set; }

        public Departament(Employee[] employees, string name, int workerlimit, double salarylimit)
        {
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }

            if (name.Length < 2)
            {
                Console.WriteLine("Adin uzunlugu 2den kicik ola bilmez");
            }
            else
            {
                Name = name;
            }
            
            if(workerlimit > 1)
            {
                WorkerLimit = workerlimit;
            }
            else
            {
                Console.WriteLine("Worker sayi 1den az ola bilmez");
            }

            if(salarylimit > 250)
            {
                SalaryLimit = salarylimit;
            }
            else
            {
                Console.WriteLine("Salary 250den az ola bilmez");
            }

        }
        public void CalcSalaryAverage()
        {

        }
    }
}
