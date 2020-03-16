using System;
using System.Collections.Generic;
using System.Linq; 


// this is a class that implements the interface 

// a palindrome reads the same forwards and backwards.
// for example, these should be considered palindromes:
// - "nurses run"
// - "racecaR"
// - "1221"
// - "never odd, or even."
// and these should not be considered palindromes:
// - "one two one"
// - "123abccba123"


namespace Palindrome
{
    class Program : Interface
    {
    
    static void Main(string[] args) 
       {
        public var str = Console.ReadLine(); 
        public var reversed = string.Concat(str.Reverse());

        if (str == reversed)
        {
            return Console.WriteLine("It is a Palindrome");
        }
        else 
        {
            return Console.WriteLine("It is not a Palindrome"); 
        }

       }

       
    }

}