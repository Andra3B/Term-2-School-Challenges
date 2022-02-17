using System;

class Program {
    public static readonly uint CHARITY_MEMBERS;

    static Program() => CHARITY_MEMBERS = Utilities.GetInputs<uint>("Enter how many charity members were there: ","count")["count"];

    public static void Main(string[] args) {
        decimal total = default;

        for(uint i = 0; i < CHARITY_MEMBERS;i++) {
            total += Utilities.GetInputs<decimal>($"Enter the amount person {i+1} collected: ","amount")["amount"];
        }

        Console.WriteLine("A total of £{0} was raised.",total);

        switch (total) {
            case < 1000m:
                total += 100m;
                break;
            case < 2000m:
                total *= 2m;
                break;
            default:
                total = 4000m+(total-2000m);
                break;
        }

        Console.WriteLine("With the company bonus, this is £{0}!!! £{0}!!! £{0}!!!",total);
    }
}