using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C01VariableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 6;
            char b= 'a';
            string c = "Hello";
            double d = 5.6;
            bool e=false;

            //in c# we have two types of data:
            // classes and structures

            WebClient wc=new WebClient();

            StringBuilder sb=new StringBuilder("very long string"); // for storing a very big strings

            //how classes differ from structures
            //clsses are reference types (reference)
            //structures are value types (copy)

            int a1 = a; // I create a copy of value 6 defined in line 15

            StringBuilder sb2 = sb; // I don't create a new object, I only assign a reference 

            DateTime dt = new DateTime(2023,5,5);
            DateTime dt2 = dt; // copy


        }
    }
}
