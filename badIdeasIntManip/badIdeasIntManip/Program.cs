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
            // Split into an array of ints and remove empty entries
            var numbers = cleanedString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                throw new NotImplementedException();
            }
        }
    }
}
