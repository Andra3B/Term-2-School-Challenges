using System;

class Program
{
    public struct Item
    {
        public string Name;
        public decimal Price;

        public Item(string name, decimal price) => (Name, Price) = (name, price);
        public override string ToString() {
            return $"{Name} - £{Math.Round(Price,2)}";
        }
    }

    public static readonly Item[] items =
    {
        new Item("Mountain Bike",200m),
        new Item("Ski Jacket",67m),
        new Item("Electric Guitar",330m),
        new Item("PS3 (500Gb)",120m),
        new Item("Badminton Racquet",15m)
    };

    public static void Main()
    {
        for(int i = 0; i < items.Length; i++) { Console.WriteLine(items[i]); } 
    }
}