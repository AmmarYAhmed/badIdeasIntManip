using System;
using System.Text.RegularExpressions;

namespace badIdeasIntManip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a series of integers seperated by spaces:");
            Console.Write("> ");
            var inputString = Console.ReadLine();
            // Remove everything except numbers and the space character
            var cleanedString = Regex.Replace(inputString, "[^0-9 ]+", string.Empty);
            // Split into an array of strings and remove empty entries
            var numberStrings = cleanedString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var numbers = new int[numberStrings.Length];
            for (var i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i], out int result))
                {
                    numbers[i] = result;
                }
            }
            
            while (true)
            {
                
                String input = Console.ReadLine();
                if (input.StartsWith("2"))
                {
                    for(int i = 0; i < numbers.Length; i++)
                    {
                        int number = numbers[i];
                        if (number % 2 == 1)
                        {
                            Console.WriteLine(number);
                        }
                    }
                }
                if (input.StartsWith("3"))
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i % 5 == 0)
                        {
                            Console.WriteLine(numbers[i]);
                        }
                    }
                }
            }
        }
    }
}
