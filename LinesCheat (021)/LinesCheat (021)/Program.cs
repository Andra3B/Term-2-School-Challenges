using System;

class Program
{
    public static readonly uint REPETITION_COUNT;

    static Program() => REPETITION_COUNT = Utilities.GetInputs<uint>("Enter how many times would you like the line copied: ", "count")["count"];

    public static void Main(string[] args)
    {
        Console.Write("Enter a sentence you would like copied: ");
        string sentence = Console.ReadLine() ?? "I must not behave like a muppet in class.";

        for(int i = 0; i < REPETITION_COUNT; i++) { Console.WriteLine(sentence); }
    }
}