using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_methodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jane", "Doe");
            Console.WriteLine(person.SayHello("Peter Smith"));

            Person friend = new Person("Chuck", "Norris");
            Console.WriteLine(person.SayHello(friend));

            Console.ReadKey();


        }
    }
}
