using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a sentence";
            Console.WriteLine(sentence);

            string question = "I asked, \"Isn't this is a sentence?\"";
            Console.WriteLine(question);

            string verbatimString = @"I asked, ""Isn't this is a sentence?""";
            Console.WriteLine(verbatimString);

            string firstString = "this is a ";
            string secondString = "string";
            string concatenateString = firstString + secondString;
            Console.WriteLine(concatenateString);

            Console.ReadKey();

        }
    }
}
