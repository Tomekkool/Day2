using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B05Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            string[] cities = new string[4];

            cities[0] = "Krakow";
            cities[1] = "Warsaw";
            cities[2] = "Singapour";

            int arrayLength = cities.Length; //4

            string searchChar = "°";
            string endChar = ">";
            const string path = @"C:\Projekty\data\cities.txt";

            string[] citiesFormFile = File.ReadAllLines(path);

            Console.WriteLine("Available cities:");

            for (int i =0; i< citiesFormFile.Length; i++)
                Console.WriteLine($"[{i+1}] {citiesFormFile[i]}");
            while (true)
            {
                Console.WriteLine("Enter the city name");
                string city = Console.ReadLine();

                string address = $"https://www.google.com/search?q=weather+{city}";

                WebClient wc = new WebClient();
                string data = wc.DownloadString(address);

                try
                {
                    int index = data.IndexOf(searchChar);
                    int currentPosition = index;
                    int iterationCount = 0;

                    while (data.Substring(currentPosition, 1) != endChar)
                    {
                        iterationCount++;
                        currentPosition--;
                    }

                    string result = data.Substring(currentPosition + 1, index - currentPosition + 1);
                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to retrieve temperature");
                    continue;
                }

            }



            Console.ReadKey();
        }
    }
}
