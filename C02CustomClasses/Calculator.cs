using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02CustomClasses
{
    internal class Calculator
    {
        //we create a method: define name, input, result, then create a body and finally tell what is the result
        public int CalculateSum(int a, int b)
        {
            int c = a + b;
            return c; 
        }

        public int CalculateDifference(int a, int b) 
        {
            int c = a - b;
            return c;
        }
    }
}
