using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResourceManager humanResourceManager = new HumanResourceManager();
            Console.Clear();
            do
            {
                Console.WriteLine("--------------------------------- Deaprtment ----------------------------------");
                Console.WriteLine("Etmek istediyiniz emeliyyati secin");
                Console.WriteLine("1 - Departameantlerin siyahisini gostermek");
                Console.WriteLine("2 - Departamenet yaratmaq");
                Console.WriteLine("3 - Departmanetde deyisiklik etmek");
                Console.WriteLine("4 - Employee uzerinde emeliyyat");
                Console.WriteLine("5 - Sistmden cix");
                Console.Write("Daxil edin : ");
                string choose = Console.ReadLine();
                int choosenum;
                int.TryParse(choose, out choosenum);
                switch (choosenum)
                {
                    case 1:
                        Console.Clear();
                        GetDepartments(ref humanResourceManager);
                        break;
                    case 2:
                        Console.Clear();
                        AddDepartment(ref humanResourceManager);
                        break;
                    case 3:
                        Console.Clear();
                        EditDepartaments(ref humanResourceManager);
                        break;
                    case 4:
                        EmployeeOperation(ref humanResourceManager);
                        break;
                    case 5:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Duzgun reqem daxil edin...");
                        break;
                }
            } while (true);
        }
        static void EmployeeOperation(ref HumanResourceManager humanResourceManager)
        {
            Console.Clear();
            do
            {
                Console.WriteLine("----------      Employee uzerinde emeliyyatlar      ----------");
                Console.WriteLine("1 - Iscilerin siyahisini gostermek ");
                Console.WriteLine("2 - Departamentdeki iscilerin siyahisini gostermrek");
                Console.WriteLine("3 - Isci elave etmek");
                Console.WriteLine("4 - Isci uzerinde deyisiklik etmek ");
                Console.WriteLine("5 - Departamentden isci silinmesi");
                Console.WriteLine("6 - Evvelki emnyuya qayit");
                Console.Write("Daxil edin : ");
                string choose = Console.ReadLine();
                int choosenum;
                int.TryParse(choose, out choosenum);
                switch (choosenum)
                {
                    case 1:
                        Console.Clear();
                        GetEmployees(ref humanResourceManager);
                        break;
                    case 2:
                        Console.Clear();
                        GetEmployeesByDepartment(ref humanResourceManager);
                        break;
                    case 3:
                        Console.Clear();
                        AddEmployee(ref humanResourceManager);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Isci uzerinde deyisiklik etmek ");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Departamentden isci silinmesi");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Evvelki emnyuya qayit");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Duzgun reqem daxil edin...");
                        break;
                }
            } while (true);
        }

        #region-Employee
        static void AddEmployee(ref HumanResourceManager humanResourceManager)
        {
            Console.WriteLine("Iscinin butov adini daxil edin : ");
            string fullname = Console.ReadLine();


            Console.WriteLine("Iscinin vezifesini daxil edin : ");
            string position = Console.ReadLine();
            while(position.Length < 2)
            {
                Console.WriteLine("Vezifenin adinin uzunlugu 2den az ola bilmez...");
                Console.Write("Vezifenin adini yeniden daxil edin : ");
                position = Console.ReadLine();
            }


            Console.WriteLine("Iscinin maasini daxil edin : ");
            string salaryName = Console.ReadLine();
            double salary;
            while(!double.TryParse(salaryName, out salary) || salary < 250)
            {
                Console.WriteLine("Iscinin maasi 250-den az ola bilmez...");
                Console.Write("Iscinin maasini duzgun daxil edin : ");
                salaryName = Console.ReadLine();
            }
            

            foreach (Department item in humanResourceManager.Departments)
            {
                Console.WriteLine("Mumkun ola bilen departmentler : ");
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Iscinin departamnetini daxil edin : ");

            string department = Console.ReadLine();
            bool checkName = true;
            int count = 0;
            while (checkName)
            {
                foreach (Department item in humanResourceManager.Departments)
                {
                    if (item.Name.ToLower() == department.ToLower())
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("Daxil etdiyiniz adda department yoxdur...");
                    Console.WriteLine("Department adini duzgun daxil edin");
                    department = Console.ReadLine();
                }
                else
                {
                    checkName = false;
                }

                count = 0;
            }

            humanResourceManager.AddEmployee(fullname, position, salary, department);
        }
        static void GetEmployees(ref HumanResourceManager humanResourceManager)
        {
            foreach (Employee item in humanResourceManager.Employees)
            {
                Console.WriteLine($"Nomresi : {item.No}\n" +
                    $"Adi : {item.FullName}\n" +
                    $"Position : {item.Position}\n" +
                    $"Salary : {item.Salary}\n" +
                    $"Department : {item.DepartmentName}\n---------------------");
            }
            humanResourceManager.GetEmployees();
        }
        static void GetEmployeesByDepartment(ref HumanResourceManager humanResourceManager)
        {
            foreach (Department item in humanResourceManager.Departments)
            {
                Console.WriteLine("Mumkun ola bilen departmentler : ");
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Iscilerini gormek istediyiniz departamnetin adini daxil edin : ");
            string departmentName = Console.ReadLine();

            
            foreach (Employee item in humanResourceManager.Employees)
            {
                if (item.DepartmentName == departmentName)
                {
                    Console.WriteLine($"Nomresi : {item.No}\n" +
                   $"Adi : {item.FullName}\n" +
                   $"Position : {item.Position}\n" +
                   $"Salary : {item.Salary}\n" +
                   $"Department : {item.DepartmentName}\n---------------------");
                }
                else
                {
                    Console.WriteLine("Bu adda department yoxdur...");
                }
            }

            humanResourceManager.GetEmployeesByDepartment(departmentName);
        }
        #endregion

        #region-Department
        static void AddDepartment(ref HumanResourceManager humanResourceManager)
        {
            Console.WriteLine("Department adini daxil edin : ");
            string department = Console.ReadLine();

            while (department.Length < 2)
            {
                Console.WriteLine("Departanmentin adini duzgun daxil edin : ");
                department = Console.ReadLine();
            }

            Console.WriteLine("Maksimum ola bilecek isci sayini daxil edin : ");
            string workerlimitName = Console.ReadLine();
            int workerlimit;
            while(!int.TryParse(workerlimitName,out workerlimit) || workerlimit <= 1)
            {
                Console.WriteLine("Maksimum isci sayini duzgun daxil edin : ");
                workerlimitName = Console.ReadLine();
            }

            Console.WriteLine("Maksimum ola bilecek maas miqdarini daxil edin : ");
            string salarylimitName = Console.ReadLine();
            int salarylimit;
            while (!int.TryParse(salarylimitName, out salarylimit) || salarylimit < 250)
            {
                Console.WriteLine("Maksimum maas miqdarini duzgun daxil edin : ");
                salarylimitName = Console.ReadLine();
            }

            humanResourceManager.AddDepartment(department,workerlimit,salarylimit);
        }
        static void EditDepartaments(ref HumanResourceManager humanResourceManager)
        {
            Console.WriteLine("Deyisdirmek istediyiniz department adini daxil edin : ");
            string department = Console.ReadLine();
            bool checkName = true;
            int count = 0;
            while (checkName)
            {
                foreach (Department item in humanResourceManager.Departments)
                {
                    if (item.Name.ToLower() == department.ToLower())
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("Daxil Etdiyniz Adda Department yoxdur ");
                    //Console.Write("Duzgun Ad Daxil Et: ");
                    //department = Console.ReadLine();
                    return;
                }
                else
                {
                    checkName = false;
                }

                count = 0;
            }


            Console.WriteLine("Departamentin yeni adini daxil edin : ");
            string newdepartment = Console.ReadLine();

            humanResourceManager.EditDepartaments(department, newdepartment);
        }
        static void GetDepartments(ref HumanResourceManager humanResourceManager)
        {
            if (humanResourceManager.Departments.Length == 0)
            {
                Console.WriteLine("Hec bir department elave edilmeyib...");
            }
            for (int i = 0; i < humanResourceManager.Departments.Length; i++)
            {
                    Console.WriteLine($"{i + 1}. {humanResourceManager.Departments[i].Name}");
            }
            Console.Write($"Umumi iscilerin sayi : {HumanResourceManager.EmployeeCount}\n");
            humanResourceManager.GetDepartments();
        }
        #endregion
    }
}
