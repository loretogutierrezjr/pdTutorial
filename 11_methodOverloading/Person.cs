using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_methodOverloading
{
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

        }

        public string SayHello(string name)
        {
            return "Hello there, " + name;
        }

        public string SayHello(Person person)
        {
            return "Hello there, " + 
                person.FirstName + " " + person.LastName;
        }
    }
}
