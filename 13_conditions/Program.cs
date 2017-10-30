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




            //-------------
            Console.ReadKey();
        }
    }
}
