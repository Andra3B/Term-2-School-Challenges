using System;

class Program
{
    public static readonly int COMPETITOR_COUNT = 3;

    public enum CompetitionCategory : byte
    {
        Junior = 12,
        Teen = 17,
        Senior = byte.MaxValue,
    }

    public struct Person
    {
        public string Name;
        public byte Age;

        public Person(string name, byte age) => (Name, Age) = (name, age);

        public CompetitionCategory GetCategory()
        {
            switch(Age) 
            {
                case < ((byte)CompetitionCategory.Junior)+1:
                    return CompetitionCategory.Junior;
                case < ((byte)CompetitionCategory.Teen)+1:
                    return CompetitionCategory.Teen;
                default:
                    return CompetitionCategory.Senior;
            }
        }
    }

    public static Person[] competitors = new Person[COMPETITOR_COUNT];

    public static void Main()
    {
        for(int competitor = 0; competitor < COMPETITOR_COUNT; competitor++)
        {
            competitors[competitor].Name = Utilities.GetInputs<string>($"Enter the name of competitor {competitor+1}: ","name")["name"];
            competitors[competitor].Age = Utilities.GetInputs<byte>($"Enter the age of competitor {competitor+1}: ", "age")["age"];
            Console.WriteLine();
        }

        Console.WriteLine("Names and competition list:");
        for(int competitor = 0; competitor < COMPETITOR_COUNT; competitor++)
        {
            Console.WriteLine("{0} - {1}",competitors[competitor].Name, competitors[competitor].GetCategory());
        }
    }
}