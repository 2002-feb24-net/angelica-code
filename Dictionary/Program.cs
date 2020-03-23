using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            //indexing 
            dict["Bob"] = 91;

            //instead of using a Dictionary, we could use a class

            string[] names = {"A", "B","C"};
            int[] grades = {1, 2, 3};
            dict = new Dictionary<string, int>()
            {
                ["Bill"] = 59
            };
        }

        //instead of using a dictionary, we could use a class to combine those
        // two values and store a List of class instances. 

    }
}
