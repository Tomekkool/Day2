using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10MultidimentionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] singleDimentionalArray = new string[3];
            string[,] twoDimentionalArray = new string[4, 2];
            string[,,] threeDimentionalArray =new string[2,3,4];

            threeDimentionalArray[0, 0, 0] = "a";
            threeDimentionalArray[0,0, 1] = "b";

            int lenght=threeDimentionalArray.Length;

            int firstDimentionSize= threeDimentionalArray.GetLength(1); //get length for element length - pure simple length - entire object length

            twoDimentionalArray[0, 0] = "A";
            twoDimentionalArray[1, 0] = "B";
            twoDimentionalArray[2, 0] = "C";
            twoDimentionalArray[3, 0] = "D";

            twoDimentionalArray[0, 1] = "E";
            twoDimentionalArray[1, 1] = "F";
            twoDimentionalArray[2, 1] = "G";
            twoDimentionalArray[3, 1] = "H";

            //FIRST METHOD - printing in rows

            Console.WriteLine("--- row wise ---");

            for (int i = 0; i < twoDimentionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimentionalArray.GetLength(1); j++)
                    Console.Write(twoDimentionalArray[i, j] + " ");  // write method doesnt create new line break 
                Console.WriteLine();
            }


            Console.WriteLine("--- column wise ---");

            for (int i = 0; i < twoDimentionalArray.GetLength(1); i++)
            {
                for (int j = 0; j < twoDimentionalArray.GetLength(0); j++)
                    Console.Write(twoDimentionalArray[j, i] + " ");  // write method doesnt create new line break 
                Console.WriteLine();
            }


            Console.ReadKey();
            }

        }

}
