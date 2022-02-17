using System;

class Program
{
	public static double RectangleArea()
	{
		Console.WriteLine("Enter the width and height of the rectangle (cm):");
		var inputs = Utilities.GetInputs<double>(string.Empty, "width", "height");

		double area = inputs["width"] * inputs["height"];
		Console.WriteLine("The area of the rectangle is {0}cm\u00B2.", area);

		return area;
	}

	public static void Main() {
		RectangleArea();
		Console.WriteLine("=======================");
		Console.WriteLine("Rectangle One:");
		double areaOne = RectangleArea();

		Console.WriteLine("\nRectangle Two:");
		double areaTwo = RectangleArea();

		Console.WriteLine("Rectangle {0} has the greatest area.",(areaOne > areaTwo) ? "One" : "Two");
    }
}