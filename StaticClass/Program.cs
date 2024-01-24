using System;
// StaticClass.dll
namespace StaticClass
{
    static class LengthConverter
    {
        public static double FeetToMeters(double ft) => ft / 3.28084;
        public static double MetersToFeet(double m) => m * 3.28084;

    }
    public class Program
    {
        static void Main(string[] args)
        {
            double feet, meters;

            // feet to meters
            feet = 100;
            meters = LengthConverter.FeetToMeters(feet);

            Console.WriteLine($"{feet}ft = {meters:0.##}m");

            // meters to feet
            meters = 10;
            feet = LengthConverter.MetersToFeet(meters);

            Console.WriteLine($"{meters}m = {feet:0.##}ft");
        }
    }
}
