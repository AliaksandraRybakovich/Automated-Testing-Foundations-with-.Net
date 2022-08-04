using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Modules.ObjectOrientedDesignPrinciples
{
    public class Receiver
    {
        private Receiver() { }
        private static Receiver _instance; 
        public static Receiver GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Receiver();
            }
            return _instance;
        }

        public void CountTypes(List<Car> cars)
        {
            var countTypes = cars.Select(m => m.Brand).Distinct().Count();
            Console.WriteLine($"количество марок автомобилей: {countTypes}");
        }

        public void CountAll(List<Car> cars)
        {
            var countAllAuto = cars.Select(m => m.Amount).Sum();
            Console.WriteLine($"общее количество автомобилей: {countAllAuto}");
        }

        public void AveragePrice(List<Car> cars)
        {
            var averagePrice = cars.Select(m => m.Cost).Average();
            Console.WriteLine($"средняя стоимость автомобиля: {averagePrice}");
        }

        public void AveragePriceType(List<Car> cars)
        {
            var avgPriceType = cars.GroupBy(b => b.Brand).Select(p => new { p.Key, averageCost = p.Average(o=>o.Cost) });
            Console.WriteLine($"средняя стоимость автомобилей каждой марки:");
            foreach (var item in avgPriceType)
            {
                Console.WriteLine($"\n Company: {item.Key}  Cost: {item.averageCost}");
            }         
        }

        public void Exit()
        {
            Environment.Exit(0);            
        }
    }
}
