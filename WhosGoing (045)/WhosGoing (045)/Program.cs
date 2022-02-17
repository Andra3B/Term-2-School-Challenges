using System;
using System.Collections.Generic;//Allows me to use the "List<T>" generic class.

class Program
{
    //Stores the list of friends names that can potentially go to the party.
    public static readonly string[] FRIENDS = { "Mellisa", "Evelyn", "Emmy", "Karen", "Margaret", "Norma", "Agnes", "Billy", "Robert", "Arthur" };
    //Stores the names of friends who are going to the party.
    public static List<string> partyList = new();

    public static void Main()
    {
        //Loops through the "FRIENDS" array and prompts the user to enter 'Y' or 'N' to who is going to the party.
        foreach (var friend in FRIENDS) {
            Console.WriteLine("Is {0} going [Y/N]: ", friend);
            if ((Console.ReadLine() ?? "N").Substring(0, 1).ToUpper() == "Y")//Input and Input validation.
                partyList.Add(friend);
        }

        //Outputs the members of the "partyList" collection.
        Console.WriteLine("\nPart List:");
        foreach (var friend in partyList) { Console.WriteLine(friend); }//Output
    }
}