using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_validatingParameters
{
    class Person
    {
        public string Name { get; private set; }

        public Person(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name cannot be null, empty, or whitespace");
            }

            this.Name = name;
        }

        public string SayHello(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name cannot be null, empty, or whitespace");
            }

            return "Hello there, " + name;
        }

        public string SayHello(Person person)
        {
            if (person == null)
            {
                throw new ArgumentException("Person cannot be null");
            }

            return SayHello(person.Name);
        }
    }
}
