using System;

class Program
{
    public static void Main(string[] args)
    {
        float temperature = Utilities.GetInputs<float>("Enter the current temperature: ", "temperature")["temperature"];
        
        switch (temperature) {
            case > 99:
                Console.WriteLine("Water will be a gas.");
                break;
            case < 1:
                Console.WriteLine("Water will be a solid.");
                break;
            default:
                Console.WriteLine("Water will be a liquid.");
                break;
        }
    }
}