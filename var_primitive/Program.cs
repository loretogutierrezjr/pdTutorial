using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_primitive
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTen = 10;
            string firstName = "Peter";
            char middleInitial = 'B';
            double height = 63.5;
            decimal depositamount = 1270.50m;
            bool isAssigned = true;

            Console.WriteLine(numberTen);
            Console.WriteLine(firstName);
            Console.WriteLine(middleInitial);
            Console.WriteLine(height);
            Console.WriteLine(depositamount);
            Console.WriteLine(isAssigned);
            Console.ReadKey();
        }
    }
}
