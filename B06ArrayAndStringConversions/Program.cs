using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B06ArrayAndStringConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //split and join methods

            string sentence = "How are you?";

            string[] words = sentence.Split(' ');

            string sentence2 = "How!$are**you";

            string[] sparators = { "!$", "**" };

           string[] words2= sentence2.Split(sparators, StringSplitOptions.RemoveEmptyEntries);

            //joining

            string[] array = { "Warsaw", "Paris", "Berlin" };

            string result= string.Join("-", array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
