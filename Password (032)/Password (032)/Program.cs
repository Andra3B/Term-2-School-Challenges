using System;

class Program
{
    private static readonly string PASSWORD = "#!UseC0micS@ns!#";

    public static void Main()
    {
        while (true)
        {
            if (Utilities.GetInputs<string>("Enter the password: ","password")["password"] == PASSWORD)
                break;

            Utilities.Error("Incorrect Password!");
        }

        Console.WriteLine("Entry Gained!");
    }
}