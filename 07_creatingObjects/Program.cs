using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_creatingObjects
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //creating objects
            StringBuilder emailMessage = new StringBuilder();
            DateTime startDate = new DateTime();

            Console.WriteLine(startDate);

            //-----------------------------------------------

            //value type
            int x = 10,
                y = x;

            //-----------------------------------------------

            //reference type
            StringBuilder initialMessage = new StringBuilder();
            StringBuilder copyMessage = new StringBuilder();
            initialMessage = copyMessage;


            initialMessage.Append("Hellow, ");
            copyMessage.Append("World");

            Console.WriteLine(initialMessage.ToString());

            initialMessage = null;

            Console.WriteLine(initialMessage);
            Console.WriteLine(copyMessage.ToString());

            int? nullableNumber = null;




            //-----------------------------------------------

            Console.ReadKey();

        }
    }

    class Test2
    {
        
    }

}
