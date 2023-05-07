using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B04Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city1 = "warsaw";
            string city2 = "London";
            string city3 = "Honkong";
            // array will help with many variables

            string[] cities = new string[4];

            cities[0] = city1;
            cities[1] = city2;
            //cities[2] = city3; missing
            cities[3] = "Singapour";

            int arrayLength= cities.Length; //4

            //Console.WriteLine(cities[0]);
            //Console.WriteLine(cities[2]);

            int[] numbers = new int[2];

            bool[] boolArray = new bool[2];
            int?[] numbers1 = new int?[2];

            int[] numbers2 = new int[3] { 4, 5, 7 };

            int[] numbers3 = { 4, 5, 7 };

            // array size cannot be modified when program is running - type is not dynamic. lists on the other hand are

            Console.ReadKey();
          

        }
    }
}
