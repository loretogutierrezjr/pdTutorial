using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_properties
{
    class myClassProp
    {
        public class Person
        {
            private string firstName;
            private string lastName;

            public string FirstName
            {
                get { return this.firstName; }

                set { this.firstName = value; }
            }

            public string LastName
            {
                get { return this.lastName; }
                set { this.lastName = value; }
            }

            public Person(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }

            public string sayHello(string name)
            {
                return "Hello, " + name;
            }
        }
    }
}
