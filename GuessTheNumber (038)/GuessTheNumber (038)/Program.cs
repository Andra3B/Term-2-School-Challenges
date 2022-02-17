using System;

class Program
{
    public static readonly (int MIN, int MAX) GAME_RANGE = (1, 100);
    public static readonly int GUESS_NUMBER = new Random().Next(GAME_RANGE.MIN, GAME_RANGE.MAX);

    public static void Main()
    {
        Console.WriteLine("Guess the number between {0} and {1}",GAME_RANGE.MIN,GAME_RANGE.MAX);
        uint guesses = 1;

        while (true)
        {
            int enteredNum = Utilities.GetInputs<int>($"(Guess {guesses}) Enter a number: ", "number")["number"];

            if (enteredNum > GUESS_NUMBER)
                Utilities.Error("Too high.");
            else if (enteredNum < GUESS_NUMBER)
                Utilities.Error("Too low.");
            else
                break;

            guesses++;
        }

        Console.WriteLine("\nCorrect! It took you {0} guess/es.",guesses);
    }
}