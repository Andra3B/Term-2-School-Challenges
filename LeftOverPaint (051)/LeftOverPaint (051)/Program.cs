using System;

class Program
{
    public static void Main()
    {
        var inputs = Utilities.GetInputs<float>(("Enter the area to be painted (m\u00B2): ","area"),("Enter the area one pot covers (m\u00B2): ","potCoverage"));

        Console.WriteLine("\nYou would need {0} pots of paint and can cover a further {1}m\u00B2 with the left over paint.",
            Math.Ceiling(inputs["area"]/inputs["potCoverage"]),
            inputs["potCoverage"]-(inputs["area"]%inputs["potCoverage"])
        );
    }
}