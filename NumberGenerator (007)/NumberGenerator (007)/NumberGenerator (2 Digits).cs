using System;

class Program
{
	public static string GetDigitsConcatenation(uint amount)
	{
		string result = string.Empty;
		foreach (var element in Utilities.GetInputs<byte>(string.Empty,amount)) { result += element.Value.ToString().Substring(0, 1); }

		return result;
	}

	public static void NumberGenerator_2Digits()
	{
		Console.WriteLine("Enter two digits [0,9]:");
		Console.WriteLine(GetDigitsConcatenation(2));
	}
	public static void NumberGenerator_3Digits()
	{
		Console.WriteLine("Enter three digits [0,9]:");
		Console.WriteLine(GetDigitsConcatenation(3));
	}

	public static void Main()
    {
		NumberGenerator_2Digits();
		Console.WriteLine("===============================");
		NumberGenerator_3Digits();
    }
}