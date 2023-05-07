using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14ListOfLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            List<List<string>> listOfLists = new List<List<string>>();

            //no multi-D lists in C#

            List<List<List<List<string>>>> listOfListOfListOfListStrings = new List<List<List<List<string>>>>();

            listOfLists.Add(new List<string>());
            listOfLists[0].Add("A");
            listOfLists[0].Add("B");

            listOfLists.Add(new List<string>());
            listOfLists[1].Add("A");
            listOfLists[1].Add("B");
            listOfLists[1].Add("C");

            listOfLists.Add(new List<string>());
            listOfLists[2].Add("A");
            listOfLists[2].Add("B");

            foreach (var row in listOfLists)
            {
            Console.WriteLine(string.Join(" ", row));
            }
            Console.ReadKey(); 
        }
    }
}
