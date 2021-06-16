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

            var shouldQuit = false;
            while (!shouldQuit)
            {
                var input = "7";

                if (input.StartsWith("1"))
                {
                    for (var i = 0; i < numbers.Length; i++)
                    {
                        var number = numbers[i];
                        if (i == numbers.Length - 1)
                        {
                            Console.Write(number);
                        }
                        else
                        {
                            Console.Write(number + ", ");
                        }
                    }
                }

                if (input.StartsWith("2"))
                {
                    for (var i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            if (i == numbers.Length - 1)
                            {
                                Console.Write(numbers[i]);
                            }
                            else
                            {
                                Console.Write(numbers[i] + ", ");
                            }
                        }
                    }
                }

                if (input.StartsWith("7"))
                {
                    shouldQuit = true;
                }

                return;
            }
        }
    }
}
