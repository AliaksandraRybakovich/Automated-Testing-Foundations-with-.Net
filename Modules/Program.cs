using Modules.Interfaces_and_abstract_classes;
using System;
using System.Linq;
using System.Text;

namespace Modules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));
            Console.Write(string.Join("", Enumerable.Repeat("-", 15)));
            Console.Write(" Module: Interfaces and abstract classes ");
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 15)));
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));

            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                try
                {
                    Console.WriteLine($"Выберете летательный аппарат: \n1. {FlyTransports.Птица}\n2. {FlyTransports.Дрон} \n3. {FlyTransports.Самолёт} \n");
                    int flyTransport = int.Parse(Console.ReadLine());
                    if (flyTransport == 1 || flyTransport == 2 || flyTransport == 3)
                    {
                        Console.WriteLine("Введите текущую координату:");
                        Console.WriteLine("Координата X");
                        uint X = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Координата Y");
                        uint Y = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Координата Z");
                        uint Z = uint.Parse(Console.ReadLine());
                        Coordinates currentPosition = new Coordinates
                        {
                            X = X,
                            Y = Y,
                            Z = Z
                        };
                        Console.WriteLine("Введите конечную координату:");
                        Console.WriteLine("Координата X");
                        uint X1 = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Координата Y");
                        uint Y1 = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Координата Z");
                        uint Z1 = uint.Parse(Console.ReadLine());
                        Coordinates destinationPoint  = new Coordinates
                        {
                            X = X1,
                            Y = Y1,
                            Z = Z1
                        };
                        switch (flyTransport)
                        {
                            case 1:
                                var bird = new Bird(FlyTransports.Птица, currentPosition);
                                Console.WriteLine($"{bird.FlyTo(destinationPoint)} \nВремя полета {bird.GetFlyTime(destinationPoint)} минут \nСкорость птицы {bird.speed}");
                                break;
                            case 2:
                                var dron = new Dron(FlyTransports.Дрон, currentPosition);
                                Console.WriteLine($"{dron.FlyTo(destinationPoint)}\nВремя полета {dron.GetFlyTime(destinationPoint)} минут");
                                break;
                            case 3:                                
                                var airplane = new Airplane(FlyTransports.Самолёт, currentPosition);
                                Console.WriteLine($"{airplane.FlyTo(destinationPoint)}\nВремя полета {airplane.GetFlyTime(destinationPoint)} минут");
                                break;
                        }
                    }
                    else
                    {
                        throw new Exception("Введите корректное число!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка!" + ex.Message);
                }
               
            }

        }
    }
}
