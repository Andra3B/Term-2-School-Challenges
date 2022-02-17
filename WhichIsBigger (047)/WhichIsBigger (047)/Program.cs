using System;

class Program {
    public static readonly (int MIN, int MAX) GAME_RANGE = (1, 1000);
    public static readonly uint GENERATION_COUNT = 2;
    public static readonly uint REPETITION_COUNT = 10;
    public static readonly Random GENERATOR = new Random();

    public struct Round
    {
        private uint _selectedOption;

        public readonly int[] Options;
        public uint SelectedOption { get => _selectedOption; set => _selectedOption = ((uint)Math.Clamp(value, 0, Options.Length-1)); }
        
        public Round() {
            Options = new int[GENERATION_COUNT];
            for (uint i = 0; i < GENERATION_COUNT; i++) { Options[i] = GENERATOR.Next(GAME_RANGE.MIN, GAME_RANGE.MAX); }
            
            _selectedOption = 0;
        }

        public bool IsCorrect() => (Options.Max() == Options[SelectedOption]);
    }

    public static readonly Round[] rounds = new Round[REPETITION_COUNT];

    static Program() => rounds.Initialize();

    public static void Main() {
        for (int round = 0; round < REPETITION_COUNT; round++) {
            Console.WriteLine("(Round {0}) I have generated {1} random numbers.",round+1,GENERATION_COUNT);
            rounds[round].SelectedOption = Utilities.GetInputs<uint>($"Which is the largest [1,{GENERATION_COUNT}]: ", "option")["option"]-1;
            Console.WriteLine();
        }

        Console.WriteLine();

        uint score = 0;
        for (int round = 0; round < REPETITION_COUNT; round++) {
            for(uint i = 0;i < rounds[round].Options.Length; i++) { Console.WriteLine("Option {0} = {1}", i+1, rounds[round].Options[i]); }

            bool isCorrect = rounds[round].IsCorrect();
            Console.WriteLine("You selected option {0}.\n{1}.\n",rounds[round].SelectedOption+1, isCorrect?"Correct":"Incorrect");

            if (isCorrect)
                score++;
        }

        Console.WriteLine("Your final score was {0}.",score);
    }
}