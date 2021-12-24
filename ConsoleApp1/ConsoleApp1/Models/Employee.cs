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
        public Departaments DepartmentName { get; set; }

        public Employee(string fullname,string position,double salary, Departaments departmentName)
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

            switch ((int)DepartmentName)
            {
                case 0:
                    No += "HU" + Count;
                    break;
                case 1:
                    No += "MA" + Count;
                    break;
                case 2:
                    No += "TE" + Count;
                    break;
                case 3:
                    No += "XE" + Count;
                    break;
                case 4:
                    No += "IN" + Count;
                    break;
                default:
                    break;
            }
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
