using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chceck if your string is palindrome:");
            string myPalindrome = Console.ReadLine();

            Palidrome palidrome = new Palidrome();

            if (palidrome.IsStringPalindrome(myPalindrome))
                Console.WriteLine("Palidrome!");
            else Console.WriteLine("Not a Palindrome.");

        }


    }
}
