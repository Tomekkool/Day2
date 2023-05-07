﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //jagged array - array of arrays

            string[] singleDimentionArray = new string[3];

            string[,] twoDimentionArray = new string[3, 2];

            //now jagged array
            string[][] jaggedArray = new string[3][];

            jaggedArray[0] =new string[2];
            jaggedArray[1] = new string[3] { "x", "y", "z" };
            jaggedArray[2] = new string[] { "u", "k" };

            int totalLength=jaggedArray.Length; // its three
            int specificInnerArrayLength = jaggedArray[1].Length;
        }
    }
}
