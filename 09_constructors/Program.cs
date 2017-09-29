using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("john", "doe");
            Console.WriteLine(person.SayHello("jerem"));

            Console.ReadKey();

        }
    }
}
