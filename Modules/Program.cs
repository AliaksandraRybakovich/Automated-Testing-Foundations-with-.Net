using Modules.ObjectOrientedDesignPrinciples;
using System;
using System.Collections.Generic;
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
            Console.Write(" Module: Object Oriented Design Principles ");
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 15)));
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));

            Console.OutputEncoding = Encoding.UTF8;

            List<Car> listOfAvto = new List<Car>();
            //{
            //    new Car("volvo", "s58", 5, 5.7),
            //new Car("mitsubishi", "s58", 7, 6.8),
            //new Car("mazda", "s58", 8, 1.4),
            //new Car("volvo", "u7", 12, 2.6),
            //new Car("lamborgini", "r5", 1, 3.7),
            //new Car("tesla", "4r", 12, 9.0),
            //};

            string brand, model;
            int autoAmount, amount;
            double cost;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите количество авто, которое будет внесено:");
                    autoAmount = int.Parse(Console.ReadLine());

                    for (int i = 0; i < autoAmount; i++)
                    {
                        try
                        {
                            Console.WriteLine("Введите марку авто:");
                            brand = Console.ReadLine();

                            Console.WriteLine("Введите модель авто:");
                            model = Console.ReadLine();

                            Console.WriteLine("Введите количество авто:");
                            amount = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите стоимость авто:");
                            cost = double.Parse(Console.ReadLine());

                            listOfAvto.Add(new Car(brand, model, amount, cost));
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Ведите корректное значение!");
                        }
                        catch (NullReferenceException)
                        {
                            Console.WriteLine("Введите значение!");
                        }
                        Console.WriteLine("\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ведите корректное значение!");
                }
            }

            Console.WriteLine("Выберите номер команды из списка: \n" +
                "0 Count Types \n 1 Count All \n 2 Average Price \n 3 Average Price Type \n 4 Exit \n");

            int numberOfCommand = int.Parse(Console.ReadLine());

            var invoker = new Invoker();

            invoker.SetCommand(numberOfCommand);
            invoker.SetCars(listOfAvto);
            invoker.Do();
        }
    }
}
