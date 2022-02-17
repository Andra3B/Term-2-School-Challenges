using System;

class Program
{
    public static readonly (uint width, uint height) gridSize = (10, 10);

    public static void Main(string[] args)
    {
        var (firstName, lastName) = (Console.ReadLine(), Console.ReadLine());

        for (uint y  = 0; y < gridSize.height; y++) {
            for (uint x = 0; x < gridSize.width/2; x++) { 
                Console.Write("{0} ",y%2==0 ? $"{firstName} {lastName}" : $"{lastName} {firstName}"); 
            }
            Console.WriteLine();
        }
    }
}