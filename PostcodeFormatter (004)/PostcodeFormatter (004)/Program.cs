using System;

class Program
{
	public static readonly byte POSTCODE_MAXIMUM_LENGTH = 8;
	public static readonly char DISCARD_CHARACTER = '_';

	public static string FormatSection(string str, byte length) => str.PadRight(length,DISCARD_CHARACTER).Substring(0,length);

	public static void Main(string[] args)
	{
		string postcodeSection1 = FormatSection(Utilities.GetInputs<string>("Enter the first three letters of the postcode: ", "characters")["characters"],2);
		string postcodeSection2 = FormatSection(Utilities.GetInputs<byte>("Enter the first two digits of the postcode: ", "digits")["digits"].ToString(),1);
		string postcodeSection3 = FormatSection(Utilities.GetInputs<byte>("Enter the second two digits of the postcode: ", "digits")["digits"].ToString(),1);
		string postcodeSection4 = FormatSection(Utilities.GetInputs<string>("Enter the second three letters of the postcode: ", "characters")["characters"],2);

		Console.WriteLine($"{postcodeSection1}{postcodeSection2} {postcodeSection3}{postcodeSection4}".ToUpper());
	}
}