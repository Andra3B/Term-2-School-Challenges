using System;

class Program
{
    public static void Main()
    {
        int end = Utilities.GetInputs<int>("Enter the end number: ", "number")["number"] + 1;
        for (int i = Utilities.GetInputs<int>("Enter the starting number: ","number")["number"];  i < end; i+=2) {
            Console.WriteLine(i);
        }
    }
}