using System;
using System.Linq;


namespace acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = getMultiTerm();
            char[] acro = InterpretStringAsArray(input);
            //PrintArray(array);
           

        }

        static string getMultiTerm()
        {
            Console.WriteLine("Please a multi-word term: ");
            Console.WriteLine("i.e 'Central Processing Unit'");
            string multiTerm = Console.ReadLine();
            return multiTerm;
        }

         static string[] InterpretStringAsArray(string str)
        {
            string[] parts = str.Split(' ');
            string[] acro = parts.Substring();
            for (int i = 0; i < acro.Length; i++)
            {
                string letter = acro[i];
                Console.Write("Acronym: " + letter);
                
            }
            return letter;
        }

        //  static void PrintArray(int[] a)
        // {
        //     Console.Write("Acronym: ");

        //     for (int i = 0; i < a.Length; i++)
        //     {
        //         string numAsString = a[i].ToString();
        //         Console.Write(numAsString + " ");
        //     }
        //     Console.WriteLine();
        // }
    
    }
}
