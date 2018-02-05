using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Package
    {
        public Package()
        {
            name = "";
            address = "";
            number = 0;
            descp = "";
            weight = 0.0;
            servtype = "";
        }
        public Package(string RName, string RAdress, int RNumber, string desc, double Weight, string Servtype)
        {
            name = RName;
            address = RAdress;
            number = RNumber;
            descp = desc;
            weight = Weight;
            servtype = Servtype;


            Console.WriteLine("Please enter your Service type");
            servtype = Console.ReadLine();

            if (servtype == "Standard")
            {
                
            }
            else
            {
                if (servtype == "Overnight")
                {

                }
                else
                {
                    if (servtype == "Sameday")
                    {

                    }
                }
            }
        }
                
        public string name;
        public string address;
        public int number;
        public string descp;
        public double weight;
        public string servtype;
    }
    }

