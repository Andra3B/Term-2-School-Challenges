using System;

class Program
{
    public const byte PAR_MAX = 5;

    public static void Main()
    {
        int standardScratch = 0;

        for(var i = PAR_MAX; i > 0;i--)
            standardScratch += Utilities.GetInputs<int>($"How many par {i} holes are there: ", "par")["par"];

        Console.WriteLine("The standard scratch for the course is {0}.",standardScratch+Utilities.GetInputs<int>(
            "What is the difficulty adjustment for the course: ", "diffAdjust")
            ["diffAdjust"]
        );
    }
}