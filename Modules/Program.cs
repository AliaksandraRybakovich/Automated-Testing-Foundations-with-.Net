using BasicOf.NetFramework;
using System;
using System.Linq;

namespace Modules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));
            Console.Write(string.Join("", Enumerable.Repeat("-", 15)));
            Console.Write(" Module: Basic of .NET Framework and C# ");
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 15)));
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));

            while (true)
            {
                try
                {        
                    Console.WriteLine("\nВведите целое число в десятичной системе");
                    int number = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите систему счисления:");
                    int numericSystem = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Число {number} в {numericSystem}-ой системе счисления:");
                    NumericSystems numSys = new NumericSystems();
                    Console.WriteLine(numSys.ConversionNumber(number, numericSystem));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка! {ex.Message}");
                }
                catch (Exception)
                {
                    Console.WriteLine("ВВЕДИТЕ КОРРЕКТНОЕ ЧИСЛО!");
                }
            }
        }
    }
}
