using System;

class Program
{
    public static readonly byte TEMP_SAMPLE_SIZE = 1;
    public static readonly (float TEMP_MIN, float TEMP_MAX) TEMP_RANGE = (-40f,55f);

    public static void Main()
    {
        float totalTemp = 0f;
        for(byte i = 1; i < TEMP_SAMPLE_SIZE+1;i++) {
            float temp = Utilities.GetInputs<float>($"Enter temperature on day {i}: ","temp")["temp"];

            if (TEMP_RANGE.TEMP_MIN > temp || temp > TEMP_RANGE.TEMP_MAX) {
                Utilities.Error($"Enter a temperature between [{TEMP_RANGE.TEMP_MIN},{TEMP_RANGE.TEMP_MAX}]!");
                i--;
            } else
                totalTemp += temp;

        }

        //Used "Math.Round" instead of a cast to an integer so that that the temperature will be round instead of truncated.
        Console.WriteLine("The average temperature was {0}\u00B0.",Math.Round(totalTemp/TEMP_SAMPLE_SIZE,0));
    }
}