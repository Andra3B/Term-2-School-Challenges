using System;

class Program
{
    public static readonly (uint players ,uint rounds, uint dartsPerRound) TOURNAMENT = (2,3,3);
    public static uint[] playerTotals = new uint[TOURNAMENT.players];

    public static void Main()
    {
        for (uint player = 0; player < TOURNAMENT.players; player++) {
            for (uint dart = 0; dart < TOURNAMENT.dartsPerRound; dart++) {
                uint dartScore = Utilities.GetInputs<uint>($"Enter the score of dart {dart+1} for player {player+1}: ", "dartScore")["dartScore"];

                if (dartScore < 61)
                    playerTotals[player] += dartScore;
                else {
                    Utilities.Error("Impossible dart score!");
                    dart--;
                }
            }
            Console.WriteLine();
        }

        uint winningPlayer = 0;
        for (uint player = 0; player < TOURNAMENT.players; player++)
        {
            uint playerTotal = playerTotals[player];

            Console.WriteLine("Player {0} scored {1}.",player+1,playerTotal);
            winningPlayer = playerTotals[winningPlayer] < playerTotal ? player : winningPlayer;
        }

        Console.WriteLine("\nPlayer {0} wins!",winningPlayer+1);
    }
}