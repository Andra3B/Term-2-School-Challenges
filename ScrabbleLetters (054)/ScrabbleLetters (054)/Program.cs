using System;
using System.Collections.Generic;

class Program
{
    public static readonly byte GENERATION_COUNT = 7;
    public static readonly Random GENERATOR = new Random();
    public static readonly Dictionary<int, string> TILE_VALUES = new Dictionary<int, string>() {
        { 1, "AEILNORSTU" },
        { 2, "DG" },
        { 3, "BCMP" },
        { 4, "FHVWY" },
        { 5, "K" },
        { 8, "JX" },
        { 10, "QZ" },
    };

    public static void Main()
    {
        Console.WriteLine("Your letters are:");
        for(var i = GENERATION_COUNT; i > 0; i--)
        {
            string? selectionString;
            int point = GENERATOR.Next(1, 11);
            point = TILE_VALUES.TryGetValue(point,out selectionString)?point:1;
            selectionString = TILE_VALUES[point];

            Console.WriteLine("{0} - {1}",selectionString[GENERATOR.Next(0,selectionString.Length)],point);
        }
    }
}