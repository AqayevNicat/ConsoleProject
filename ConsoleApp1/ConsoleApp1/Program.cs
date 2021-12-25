using ConsoleApp1.Enums;
using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            do
            {
                Console.WriteLine("--------------------------------- Employee ----------------------------------");
                Console.WriteLine("Etmek istediyiniz emeliyyati secin");
                Console.WriteLine("1 - Departameantlerin siyahisini gostermek");
                Console.WriteLine("2 - Departamenet yaratmaq");
                Console.WriteLine("3 - Departmanetde deyisiklik etmek");
                Console.WriteLine("4 - Sistmden cix");
                Console.Write("Daxil edin : ");
                string choose = Console.ReadLine();
                int choosenum;
                int.TryParse(choose, out choosenum);
                switch (choosenum)
                {
                    case 1:
                        Console.Clear();
                        MenuOperaion();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Department yarat");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Department deyis");
                        break;
                    case 4:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Duzgun reqem daxil edin...");
                        break;
                }
            } while (true);
        }
        static void MenuOperaion()
        {
            Console.Clear();
            do
            {
                Console.WriteLine("----------      Department ve Employee uzerinde emeliyyatlar       ----------");
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
                        Console.WriteLine("Iscilerin siyahisini gostermek");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" Departamentdeki iscilerin siyahisini gostermrek");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Isci elave etmek");
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
    }
}
