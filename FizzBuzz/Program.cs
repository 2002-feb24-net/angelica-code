using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;

         for(int i = 0; i<=1000; i++)
            {
                if(i % 3 == 0 && i % 5 != 0)
                {
                    System.Console.WriteLine("Fizz");
                    x++;
                }
                else if(i % 5 == 0 && i % 3 != 0)
                {
                  System.Console.WriteLine("Buzz");
                    y++;
                }
                else if((i % 3 == 0) && (i % 5 ==0))
                {
                    System.Console.WriteLine("FizzBuzz");
                    z++;

                }
                else
                {
                    System.Console.WriteLine(i);
                }

            }

            System.Console.WriteLine("There are " + x + " Fizzes"); // 267 Fizzes
            System.Console.WriteLine("There are " + y + " Buzzes"); // 134 Buzzes
            System.Console.WriteLine("There are " + z + " FizzBuzzes"); //67 FizzBuzzes

            
        
        }

        

        


    }
}
