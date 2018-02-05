using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Gold newmember;
            newmember = new Gold();
            string choice;
            DisplayMenu();
            choice = Console.ReadLine();

            while (choice!="3")
            {
                switch(choice)
                {
                    case "1":
                        Guest();
                        break;
                    case "2":
                        Gold();
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid entry, Please re-enter choice");
                            Console.Clear();
                            DisplayMenu();
                            break;
            
                        }
                }
              // Console.Clear();
                // DisplayMenu();

                
                choice = Console.ReadLine();
            }
        }
        static void DisplayMenu()
        {
            Console.WriteLine("Welcome to ComCol's Express Delivery Company\n");
             Console.WriteLine("1.Regular/Guest Membership");
             Console.WriteLine("2.Gold Membership");
             Console.WriteLine("3.Exit\n");
             Console.WriteLine();
             Console.WriteLine("Enter your choice:");
        }
        static void Guest()
        {
            Console.Clear();
            Console.WriteLine("Enter your name:");

            Console.WriteLine("Enter your address:");
            Console.WriteLine("Enter your telephone number:");
            Console.WriteLine("Enter your Payment method:");
        }

        static void Gold()
        {

        }
    }
}
