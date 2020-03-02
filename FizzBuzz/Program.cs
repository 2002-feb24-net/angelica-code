using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
         int value = RunProgram();
         int input = int.Parse(Console.ReadLine());
        
        }

        static int RunProgram()
        {
            for(int i = 0; i<1000; i++)
            {
                if(i % 3 == 0)
                {
                    int f = System.Console.WriteLine("Fizz");
                    return f;
                    
                }
                else if(i % 5 == 0)
                {
                   int b = System.Console.WriteLine("Buzz");
                   return b;
                    
                }
                else if(i % 3 == 0 && i % 5 ==0)
                {
                    int fb = System.Console.WriteLine("FizzBuzz");
                     return fb;

                }

            }
        }

        


    }
}
