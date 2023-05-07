using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02CustomClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c=new Calculator();//c is a variable with a new object assigned
            // c is only a handle to an object, not object per se

            Calculator c1; // This is not an object, this is only a variable

            new Calculator(); //we dont use it usually, cuz its not referenced anywhere

            Calculator c2;

            c2= new Calculator();
            //here we have three separate calculators in our memory

            int g=c.CalculateSum(3, 4);
            int g1 = c.CalculateDifference(4, 3);

            Console.WriteLine(g);
            Console.WriteLine(g1);

            Console.ReadKey();  

        }
    }
}
