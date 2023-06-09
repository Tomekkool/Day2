﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B09EXVolleyball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a country name");
            string country=Console.ReadLine().ToLower();


           const string path = "http://tomaszles.pl/wp-content/uploads/2023/05/volleyball_players.csv";


            WebClient wc = new WebClient();
            string data = wc.DownloadString(path);

            string[] separator = new string[1] { "\r\n" };
            string[] rows = data.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            List<string> players = new List<string>();

            foreach (string row in rows)
            {

                string[] cells = row.Split(';');
                if (cells[4].ToLower()==country)
                    players.Add(cells[2] +" " + cells[3]);
                
            }

            const string outputPath = @"c:\Projekty\data\countries";
            if(!Directory.Exists(outputPath)) 
                Directory.CreateDirectory(outputPath);

            if (!File.Exists(outputPath + $"\\{country}.txt"))
                File.WriteAllLines(outputPath + $"\\{country}.txt", players);
            //string[] playersFromFile = File.ReadAllLines(path);


        }
    }
}
