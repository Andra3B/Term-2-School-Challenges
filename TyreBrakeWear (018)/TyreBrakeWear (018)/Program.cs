using System;
using System.Collections.Generic;

class Program
{
    public static readonly Dictionary<float, float> STOPPING_DISTANCES = new()
    {
        { 20f, 6f },
        { 30f, 14f },
        { 40f, 24f },
        { 50f, 38f },
        { 60f, 55f },
        { 70f, 75f },
    };

    public static void Main(string[] args)
    {
        Dictionary<string, float> inputs;

        while (true)
        {
            inputs = Utilities.GetInputs<float>(("Enter the test speed: ","testSpeed"),("Enter the stopping distance: ", "stoppingDistance"));

            if (inputs["testSpeed"] < 20) {
                Utilities.Error("The test speed must be atleast 20mph!");
                continue;
            }

            if (!(inputs["stoppingDistance"] > 0)) {
                Utilities.Error("The stopping distance must be greater then zero!");
                continue;
            }

            break;
        }

        Console.WriteLine("Your car {0} the braking and distance test.", inputs["stoppingDistance"] > STOPPING_DISTANCES[(((uint)inputs["testSpeed"])/10)*10] ? "failed" : "passed");
    }
}