using System;

class Program {
    public static readonly uint PUPILS = 3;

    public static void Main() {

        float totalTime = 0;
        for(uint pupil = 0; pupil < PUPILS; pupil++) {
            Console.WriteLine($"Enter the time of pupil {pupil+1}:");
            totalTime += Utilities.GetInputs<float>(string.Empty, "time")["time"];
        }

        Console.WriteLine("The average time was {0} seconds.",totalTime/PUPILS);
    }
}