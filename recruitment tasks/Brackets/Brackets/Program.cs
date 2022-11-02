using Brackets.Validation;
using System;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your bracket string:");
            string userString = Console.ReadLine();

            BracketValidation validation = new BracketValidation(userString);
            bool IsBracketAmountCorrect = validation.CountedValuesSame();

            if (IsBracketAmountCorrect)
                Console.WriteLine("You correctly used brackets");
            else Console.WriteLine("Wrong number of brackets");
        }
    }
}
