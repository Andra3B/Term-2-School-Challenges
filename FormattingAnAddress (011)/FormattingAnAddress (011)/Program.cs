using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the town, street and house number:");

        string[] inputs = new string[3];
        Utilities.GetInputs<string>(string.Empty,"townName","streetName").Values.CopyTo(inputs, 0);
        inputs[inputs.Length-1] = Utilities.GetInputs<uint>(string.Empty,"homeNumber")["homeNumber"].ToString();

        Console.WriteLine(string.Join(", ", inputs));//Output
    }
}