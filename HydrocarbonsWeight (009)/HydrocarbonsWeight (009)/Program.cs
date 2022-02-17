using System;

class Program
{
    public static void Main()
    {
        uint carbonCount = Utilities.GetInputs<uint>("Enter the number of carbon atoms: ", "carbonCount")["carbonCount"];
        uint hydrogenCount = (carbonCount * 2) + 2;

        Console.WriteLine("The atomic mass of C{0}H{1} is {2}",carbonCount,hydrogenCount,(carbonCount*12)+hydrogenCount);
    }
}