using System;
using System.IO;

class Program
{
    public static readonly byte GENERATION_COUNT = 15;
    public static readonly Random GENERATOR = new Random();
    public static readonly string HORSE_NAMES_LOCATION = @"HorseNames.txt";

    public class Horse
    {
        public string Name;
        public byte Age;
        public double Height;

        public Horse(string name, byte age, double height) => (Name, Age, Height) = (name, age, height);
    }

    public static Horse[] horses;

    static Program()
    {
        horses = new Horse[GENERATION_COUNT];
        string[] horseNames = new string[0];

        if (File.Exists(HORSE_NAMES_LOCATION))
            horseNames = File.ReadAllLines(HORSE_NAMES_LOCATION);
        else {
            Utilities.Error($"An error occured trying to open \"{HORSE_NAMES_LOCATION}\" application terminated!");
            Environment.Exit(1);
        }

        for (uint horseIndex = 0; horseIndex < GENERATION_COUNT; horseIndex++)
        {
            byte horseAge = (byte)GENERATOR.Next(2,13);
            horses[horseIndex] = new Horse(
                horseNames[GENERATOR.Next(0,horseNames.Length)],
                horseAge,
                (byte)(4+horseAge+GENERATOR.NextDouble())
            );
        }
    }

    public static void Main()
    {
        #region RAT
        #if DEBUG

        for (uint horse = 0; horse < GENERATION_COUNT; horse++)
        {
            Console.WriteLine("Name: {0} | Age: {1} | Height: {2}hh", horses[horse].Name, horses[horse].Age, horses[horse].Height);
        }

        Console.WriteLine();

        #endif
        #endregion

        byte filterAge = Utilities.GetInputs<byte>("Enter the maximum age: ", "age")["age"];
        double filterHeight = Utilities.GetInputs<double>("Enter the maximum height (hh): ", "height")["height"];

        Console.WriteLine();

        for (uint horse = 0; horse < GENERATION_COUNT; horse++)
        {
            if (horses[horse].Age < filterAge && horses[horse].Height < filterHeight)
                Console.WriteLine("Name: {0} | Age: {1} | Height: {2}hh", horses[horse].Name, horses[horse].Age, horses[horse].Height);
        }
    }
}
