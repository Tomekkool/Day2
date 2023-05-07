using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04CalculatorEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();

           double? g = c.PerformOperation(3, 4,'+');
            double? g1 = c.PerformOperation("8-2");

            Console.WriteLine(g);
            Console.WriteLine(g1);
            Console.ReadKey(); 
        }
    }
}
