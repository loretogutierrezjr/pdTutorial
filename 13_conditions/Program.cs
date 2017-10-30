using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = 6 >= 5;
            Console.WriteLine(result);

            //-------------

            bool staticMethods = string.IsNullOrEmpty("Test");
            Console.WriteLine(staticMethods);

            //-------------

            Person loreto = new Person("Loreto");
            bool logicalAnd = loreto != null && (loreto.Name == loreto.Name);
            Console.WriteLine(logicalAnd);

            //-------------

            bool hasValue = !string.IsNullOrEmpty("test");
            Console.WriteLine(hasValue);

            //-------------

            int month = 2;
            if (month == 1)
            {
                Console.WriteLine("January");

            }
            else if (month == 2)
            {
                Console.WriteLine("February");
            }
            else
            {
                Console.WriteLine("March - December");
            }

            //-------------

            string firstName = loreto != null ? loreto.Name : string.Empty;
            Console.WriteLine(firstName);

            //-------------

            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                default:
                    Console.WriteLine("April-December");
                    break;
            }

            //-------------
            Console.ReadKey();
        }
    }
}
