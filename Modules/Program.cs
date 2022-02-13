using BasicOf.NetFrameworkAndC;
using Modules.DevelopmentAndBuildTools;
using System;
using System.Linq;

namespace Modules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));
                Console.Write(string.Join("", Enumerable.Repeat("-", 15)));
                Console.Write(" Module: Development and Build Tools ");
                Console.WriteLine(string.Join("", Enumerable.Repeat("-", 15)));
                Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));

                Console.WriteLine("\nВведите строку:");
                string message = Console.ReadLine();

                Console.Write($"Неповторяющаяся последовательность: \n");

                Console.WriteLine(UniqueCharacters.RemoveDuplicate(message));               
            }
        }
    }
}
