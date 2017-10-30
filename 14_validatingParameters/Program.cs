using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_validatingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mariel");
            Console.WriteLine(person.SayHello(string.Empty));

            Console.ReadKey();
        }
    }
}
