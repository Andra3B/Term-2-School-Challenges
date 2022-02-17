using System;

class Program {
    public static readonly string MESSAGE = "Use Comic Sans";

    public static void Main() {
        while (true) {
            Console.Write("Would you like some advice [Y/N]: ");
            switch ((Console.ReadLine() ?? "x").ToLower())
            {
                case "n":
                    Utilities.Error("You need the advice!");
                    break;
                case "y":
                    Console.WriteLine(MESSAGE);
                    return;
                default:
                    Utilities.Error("Enter [Y/N] only!");
                    break;
            }
        }
    }
}