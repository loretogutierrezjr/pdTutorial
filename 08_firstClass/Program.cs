using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_firstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person("Loreto", "Gutierrez");
            Console.WriteLine(me.SayHello("Loreto"));
            
            Console.WriteLine(me);

            Console.WriteLine("test hello");


            Console.WriteLine("--------------------------------");

            Person me2 = new Person("Loreto", "Gutierrez");
            Console.WriteLine(me2.SayHello("Retz"));


            Console.ReadKey();


        }
    }
}
