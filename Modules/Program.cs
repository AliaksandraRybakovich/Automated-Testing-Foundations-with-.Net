using Modules.OOP.Details;
using Modules.OOP.Transports;
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
            Console.Write(" Module: OOР ");
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 15)));
            Console.WriteLine(string.Join("", Enumerable.Repeat("-", 70)));

            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                Transport car = new Car(96.7, NameTransport.Car,
                    new Engine(100, 1.4, TypeEngine.Дизель, "1234523RT", NameDetails.Двигатель),
                    new Chassis(4, "173678263", 2, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Заднеприводный, 6, "Japan", NameDetails.Трансмиссия));
                Console.WriteLine(car.ToString());

                Console.WriteLine("\n");

                Transport scooter = new Scooter(65, NameTransport.Scooter,
                    new Engine(25, 0.8, TypeEngine.Электрический, "1829304КВ", NameDetails.Двигатель),
                    new Chassis(2, "78263", 0.2, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Переднеприводный, 2, "China", NameDetails.Трансмиссия));
                Console.WriteLine(scooter.ToString());

                Console.WriteLine("\n");

                Transport bus = new Bus(11, NameTransport.Bus,
                    new Engine(90, 1.2, TypeEngine.Дизель, "76459В", NameDetails.Двигатель),
                    new Chassis(4, "87543", 3, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Переднеприводный, 5, "Russia", NameDetails.Трансмиссия));
                Console.WriteLine(bus.ToString());

                Console.WriteLine("\n");

                Transport truck = new Truck(2, NameTransport.Truck,
                    new Engine(120, 1.6, TypeEngine.Газ, "234987", NameDetails.Двигатель),
                    new Chassis(4, "098789", 4, NameDetails.Шасси),
                    new Transmission(TypeTransmission.Полноприводный, 4, "Belarus", NameDetails.Трансмиссия));
                Console.WriteLine(truck.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка! {ex.Message}");
            }
        }
    }
}
