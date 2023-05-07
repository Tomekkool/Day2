using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05EXTextManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence you want to test for the longest word.");
            string sentence = Console.ReadLine();
            TextManager tm = new TextManager();
            
            string longestWord = tm.FindLongestWord(sentence);
            Console.WriteLine("First longest word is:");
            Console.WriteLine(longestWord); 

            Console.WriteLine();

            TextManager tm2 = new TextManager();
            List<string> allLongestWords = tm2.FindAllLongestWords(sentence);

            Console.WriteLine("All the longest words in the sentence are:");

            foreach(string word in allLongestWords)
                     
                Console.WriteLine(word);


            Console.ReadKey();
        }
        }
    }

