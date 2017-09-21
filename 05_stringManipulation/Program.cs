using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_stringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "john";
            int length = name.Length;
            Console.WriteLine(length);

            Console.WriteLine("\n");

            string phrase = "hello, world";
            int index = phrase.IndexOf("h");
            Console.WriteLine(index);

            Console.WriteLine("\n");

            string getInsidePharse = phrase.Substring(7);
            Console.WriteLine(getInsidePharse);

            Console.WriteLine("\n");

            string getInsidePhraseWithLength = phrase.Substring(2, 3);
            Console.WriteLine(getInsidePhraseWithLength);

            Console.WriteLine("\n");

            string removeInsidePhrase = phrase.Remove(0, 7);
            Console.WriteLine(removeInsidePhrase);

            Console.WriteLine("\n");

            string replaceInsidePhrase = phrase.Replace("l", "x");
            Console.WriteLine(replaceInsidePhrase);

            Console.WriteLine("\n");

            phrase = phrase.Replace("l", "r");
            Console.WriteLine(phrase);

            Console.WriteLine("---------------------------");

            Console.WriteLine("\n");
            string str = "Loreto";

            string getInsideStr = str.Substring(1, 5);
            Console.WriteLine(getInsideStr);

            Console.ReadKey();

        }
    }
}
