namespace Modules.ObjectOrientedDesignPrinciples
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Amount { get; set; }
        public double Cost { get; set; }

        public Car(string brand, string model, int amount, double cost)
        {
            Brand = brand;
            Model = model;
            Amount = amount;
            Cost = cost;
        }
    }
}
