﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B08EXLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string searchChar = "°";
            string endChar = ">";
            const string path = @"cities.txt";
            // const string absolutePath = @"c:\data\cities.txt";

            string[] citiesFromFile = File.ReadAllLines(path);

            Console.WriteLine("Avaible cities:");
            for (int i = 0; i < citiesFromFile.Length; i++)
                Console.WriteLine($"[{i + 1}] {citiesFromFile[i]}");

            List<int> tempList = new List<int>();
            List<string> cityList = new List<string>();

            while (true)
            {
                //Console.WriteLine("Enter the city name");
                // string city = Console.ReadLine();
                Console.WriteLine("select a city (enter the number)");
                string cityString = Console.ReadLine();
                int cityNumber = Convert.ToInt32(cityString);
                string city = citiesFromFile[cityNumber - 1];


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
                    Console.WriteLine($"Temperature for {city}: {result}");

                    tempList.Add(Convert.ToInt32(result.Substring(0, result.Length-2)));

                    double averageTemp = 0;

                   foreach (var t in tempList) 
                    {
                    averageTemp += t;
                    }

                   averageTemp /=tempList.Count;

                    string report=string.Format("The avg tenp in cities {0} is {1}", string.Join(", ",cityList), averageTemp);

                    Console.WriteLine(report); 
                }
                catch (Exception)
                {
                    Console.WriteLine("Faild to retrieve temperature");
                    continue;
                }

            }
            Console.ReadKey();
        }
    }
}
