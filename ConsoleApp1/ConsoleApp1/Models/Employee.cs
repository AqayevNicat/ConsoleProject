using ConsoleApp1.Enums;
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

        public Employee(string fullname,string position,double salary, string departmentName)
        {
            Count++;
            FullName = fullname;
            DepartmentName = departmentName;
            if (position.Length < 2)
            {
                Position = "Position adini duzgun daxil edin...";
            }
            else
            {
                Position = position;
            }
            
            if(salary < 250)
            {
                Salary = 0;
            }
            else
            {
                Salary = salary;
            }

            No =$"{DepartmentName[0]}{ DepartmentName[1]}" + Count;
            Workercount++;
            WorkerNo = Workercount;

        }
        public override string ToString()
        {
            return $"Nomresi : {No}\n" +
                $"FullName : {FullName}\n" +
                $"Position : {Position}\n" +
                $"Salary : {Salary}\n" +
                $"Department : {DepartmentName}\n" +
                $"WorkerCount : {WorkerNo}--------------------";
        }
    }
}
