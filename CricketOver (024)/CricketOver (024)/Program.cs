using System;

class Program
{
    public static readonly byte SCORE_COUNT = 6;

    public static void Main()
    {
        string output = string.Empty;
        uint total = 0;

        for(int scoreIndex = 0; scoreIndex < SCORE_COUNT; scoreIndex++) {
            Console.Write("Enter the score of ball {0}: ",scoreIndex+1);
            uint score = Utilities.GetInputs<uint>(string.Empty, "score")["score"];
            total += score;
            output += score + "\n";
        }

        Console.WriteLine("\nThis over's score was: {0}\nWith each ball scoring:\n{1}",total,output);
    }
}