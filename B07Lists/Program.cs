using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B07Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>(); //list not initialize lenghth, empty list

            list<string> ist2 = null; // this is null list so i cannot use it

            // cannot use methods on null variables

            list.Add("Warsaw");
            list.Add("Berlin");
            ///you can inser element on specific position
            list.Insert(1, "paris");
            string city1 = list[0];
            string city3 = list[list.Count - 1];//last element

            //you can remove elements from the list

            list.RemoveAt(1);
            list.RemoveAt("paris");// removes first instance of paris

            //list.RemoveAll() - for later
        }
    }
}
