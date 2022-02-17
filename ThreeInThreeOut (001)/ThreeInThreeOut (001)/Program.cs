using System;

class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter your age, name and favourite TV program:");

		Console.WriteLine("{0} is {1} years old and likes {2}",
			Console.ReadLine(),
			Utilities.GetInputs<byte>(string.Empty, "age")["age"],
			Console.ReadLine()
		);
	}
}