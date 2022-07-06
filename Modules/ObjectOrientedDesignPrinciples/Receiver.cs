using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Modules.ObjectOrientedDesignPrinciples
{
    public class Receiver
    {
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
            var avgPriceType = cars.Select(m => m.Cost).ToList();
            Console.WriteLine("средняя стоимость автомобилей каждой марки:");
            foreach (var item in avgPriceType)
            {
                Console.WriteLine(item);
            }
        }
        public void Exit(List<Car> cars)
        {
            Environment.FailFast("Exit!");
            Environment.Exit(0);
        }
    }
}
