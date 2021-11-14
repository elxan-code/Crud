using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choise = 255;
            ContactAdress c1 = new ContactAdress();
            Console.WriteLine("Welcome to Get Adress");
            do
            {
              
                Console.WriteLine();
                Console.WriteLine("you must coose this list ");
                Console.WriteLine();
                Console.WriteLine("1.New Contact");
                Console.WriteLine("2. Delete Contack");
                Console.WriteLine("3.Uptade Contact");
                Console.WriteLine("4.Find Contact");
                Console.WriteLine("0.Exit");
                if (byte.TryParse(Console.ReadLine(),out choise))
                {
                    switch (choise)
                    {
                        case 1:
                            ContactAdress c3 = new ContactAdress();
                            
                            Console.WriteLine("Enter the Name");
                            c3.name = Console.ReadLine();


                            Console.WriteLine("Enter the Surname");
                            c3.surname = Console.ReadLine();

                            Console.WriteLine("Enter the Country");
                            c3.country = Console.ReadLine();


                            Console.WriteLine("Enter the City");
                            c3.city = Console.ReadLine();

                            Console.WriteLine("Enter the Adress");
                            c3.adres = Console.ReadLine();

                            Console.WriteLine("Enter the PhoneNumber");
                            c3.PhoneNumber = Console.ReadLine();


                            break;
                        case 2:
                            Console.WriteLine("Delete");
                            break;
                        case 3:
                            Console.WriteLine("Uptade");
                            break;
                        case 4:
                            Console.WriteLine("Find");
                            break;
                        case 0:
                            Console.WriteLine("Exit");
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter the number!");
                    choise = 255;
                }

            } while (choise!=0);
        }
    }
}
