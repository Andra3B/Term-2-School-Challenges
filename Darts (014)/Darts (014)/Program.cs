using System;

class Program {
    public static readonly string HIGH_SCORE_MESSAGE = "What a great score! Well done.";
    public static readonly string MEDIUM_SCORE_MESSAGE = "It's an alright score.";
    public static readonly string LOW_SCORE_MESSAGE = "That was rubbish. Get practicing!";

    public static void Main(string[] args) {
        string output;
        switch (Utilities.GetInputs<byte>("Enter your score: ","score")["score"]) {
            case < 10:
                output = LOW_SCORE_MESSAGE;
                break;
            case > 100:
                output = HIGH_SCORE_MESSAGE;
                break;
            default:
                output = MEDIUM_SCORE_MESSAGE;
                break;
        }

        Console.WriteLine(output);
    }
}