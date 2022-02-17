using System;

class Program
{
    public static readonly (uint MIN, uint MAX) GAME_RANGE = (97, 122);
    public static readonly char GUESS_CHARACTER = (char)(new Random().Next((int)GAME_RANGE.MIN,(int)GAME_RANGE.MAX));

    public static void Main()
    {
        Console.WriteLine("Guess what character is represented by the ASCII codes from {0}({1}) to {2}({3})\n",
            GAME_RANGE.MIN,(char)GAME_RANGE.MIN,
            GAME_RANGE.MAX,(char)GAME_RANGE.MAX
        );

        uint guesses = 1;
        while (true)
        {
            char guess = Utilities.GetInputs<char>($"(Guess {guesses}) What is the character that is {(uint)GUESS_CHARACTER} in ASCII: ","character")["character"];

            if (guess == GUESS_CHARACTER)
                break;

            Utilities.Error($"No, '{guess}' would be {(uint)guess}");
            guesses++;
        }

        Console.WriteLine("\nCorrect!, '{0}' is {1}.\nIt took you {2} guess/es.",GUESS_CHARACTER,(uint)GUESS_CHARACTER,guesses);
    }
}