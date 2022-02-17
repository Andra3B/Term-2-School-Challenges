using System;

class Program
{
	public static void Main(string[] args)
	{
		double radius = Utilities.GetInputs<double>("Enter the radius of the circle (cm): ", "radius")["radius"];

		Console.WriteLine("The area of the circle is {0}cm\u00B2 (3 d.p).", Math.Round((radius*radius) * Math.PI, 3));
	}
}