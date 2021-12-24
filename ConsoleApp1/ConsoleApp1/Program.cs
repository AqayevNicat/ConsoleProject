using ConsoleApp1.Enums;
using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Nicat Aqayev","Director",3000,Departaments.Huquq);
            Employee employee2 = new Employee("Tofiq Aqayev","A",700,Departaments.Inzibati);
            Employee employee3 = new Employee("Fidan Aqayev","Supurge",200,Departaments.Maliyye);
            Employee employee4 = new Employee("Ferhad Aqayev","Qa",500,Departaments.Tedqiqatlar);
            Employee employee5 = new Employee("Nesimi Aqayev","Aspaz",1000,Departaments.Xezine);
            Employee employee6 = new Employee("Bigli Aqayev","Mudur",2000,Departaments.Maliyye);

            Employee[] employees = { employee1, employee2, employee3, employee4, employee5, employee6 };

            Departament depart = new Departament(employees,"Huquq",50,5000);

            Console.WriteLine(depart);
        }
    }
}
