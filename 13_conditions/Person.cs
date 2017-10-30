using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_conditions
{
    class Person
    {
        public string Name
        {
            get; private set; 
        }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
