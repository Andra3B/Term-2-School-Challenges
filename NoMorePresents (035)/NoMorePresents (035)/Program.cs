using System;

class Program
{
    public static readonly decimal LIMIT = 200m;

    public static void Main()
    {
        decimal total = 0m;
        decimal latestItemCost = 0m;

        for (int i = 1;; i++)
        {
            latestItemCost = Utilities.GetInputs<decimal>($"Enter the cost of present {i}: £", "cost")["cost"];

            if (total + latestItemCost < LIMIT) {
                total += latestItemCost;
            } else { break; }
        }

        Console.WriteLine("Limit Exceeded! You can't include the last present of £{0}.",latestItemCost);
    }
}