using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Employee
    {
        public static int Count = 1000;
        public static int Workercount { get; set; }
        public int WorkerNo { get; set; }
        public string No { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }

        public static double ortasal = 0;

        public Employee(string fullname, string position, double salary, string departmentName)
        {
            Count++;
            FullName = fullname;
            DepartmentName = departmentName;
            Position = position;
            Salary = salary;
            ortasal += salary;

            Workercount++;  
            WorkerNo = Workercount;
            No = $"{DepartmentName[0]}{ DepartmentName[1]}".ToUpper() + Count;
        }
        public override string ToString()
        {
            return $"Nomresi : {No}\n" +
                $"FullName : {FullName}\n" +
                $"Position : {Position}\n" +
                $"Salary : {Salary}\n" +
                $"Department : {DepartmentName}\n";
        }
    }
}
