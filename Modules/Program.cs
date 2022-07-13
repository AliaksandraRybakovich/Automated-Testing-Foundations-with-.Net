using Modules.DevelopmentAndBuildTools;
using System;
using System.Linq;
using System.Text;

namespace Modules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));
            Console.Write(string.Join("", Enumerable.Repeat("-", 15)));
            Console.Write(" Module: Development and Build Tools ");
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 15)));
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));

            Console.OutputEncoding = Encoding.UTF8;

            string message = string.Empty;

            while (true)
            {
                try
                {
                    Console.WriteLine("\nEnter the line:");
                    message = Console.ReadLine();
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.Write($"Non-repeating sequence: \n");

                try
                {
                    Console.WriteLine(UniqueCharacters.RemoveDuplicate(message));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.Write($"Maximum number of consecutive identical letters of the Latin alphabet per line: \n");

                Console.WriteLine(UniqueCharacters.MaxAmountLettersInSequence(message));


                Console.Write($"Maximum number of consecutive identical digits: \n");

                Console.WriteLine(UniqueCharacters.MaxAmountDigitsInSequence(message));
            }

        }
    }
}
