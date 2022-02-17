using System;

namespace FormatPhoneNumber__012_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the area code and local code:");
            var inputs = Utilities.GetInputs<uint>(string.Empty, "areaCode", "localCode");

            Console.WriteLine("0{0} {1}", inputs["areaCode"].ToString().PadLeft(4, '0').Substring(0, 4), inputs["localCode"].ToString().PadLeft(6,'0').Substring(0,6));
        }
    }
}
