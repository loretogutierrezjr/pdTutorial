using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            myClassProp.Person person = new myClassProp.Person("John", "Doe");
            person.FirstName = "Xavier";
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName); Console.ReadKey();
            
        }
    }
}
