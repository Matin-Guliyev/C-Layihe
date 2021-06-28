using Layihe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layihe
{
    class Program
    {
        static void Main(string[] args)
        {
            string mtn;

            do
            {
                Console.WriteLine("\n====================================================\n");
                Console.WriteLine("1.1 - Departamentlerin siyahisini gostermek");
                Console.WriteLine("1.2 - Yeni Department yaratmaq");
                Console.WriteLine("1.3 - Departamen uzerinde deyisiklik etmek");
                Console.WriteLine("2.1 - Butun iscilerin siyahisini gostermek");
                Console.WriteLine("2.2 - Departamentdeki iscilerin siyahisini gostermek");
                Console.WriteLine("2.3 - Isci elave etmek");
                Console.WriteLine("2.4 - Isci uzerinde deyisiklik etmek");
                Console.WriteLine("2.5 - Departamentden isci silinmesi");
                Console.WriteLine("3 - sistemden cixis");

                Console.WriteLine("\nIcra etmek istediyiniz emeliyyati secin:");
                mtn = Console.ReadLine();

                Console.WriteLine("\n====================================================\n");

                switch (mtn)
                {
                    case "1.1":
                        ManagerOfHumanMenu.GetDepartmentsMenu();
                        break;
                    case "1.2":
                        ManagerOfHumanMenu.AddDepartmentMenu();

                        break;
                    case "1.3":
                        ManagerOfHumanMenu.EditDepartamentsMenu();
                        break;
                    case "2.1":
                        ManagerOfHumanMenu.EditEmployee();
                        break;
                    case "2.2":
                        ManagerOfHumanMenu.GetEmployees();
                        break;
                    case "2.3":
                        ManagerOfHumanMenu.AddEmployee();

                        break;
                    case "2.4":
                        ManagerOfHumanMenu.EditEmployee();
                        break;
                    case "2.5":
                        ManagerOfHumanMenu.RemoveEmployeeMenu();
                        break;

                    default:
                        if (mtn != "3")
                        {
                            Console.WriteLine("Duzgun deyer daxil edilmedi");
                        }
                        break;

                }

            } while (mtn != "3");



        }


    }
    }

