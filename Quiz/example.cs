using System;

namespace Quiz
{
    public class example
    {
        public enum FeetConvert { Centimeters, Inches, Meters, Millimeters, Yards }

        public void ConversionFeet(double value, FeetConvert feetConvert)
        {
            switch (feetConvert)
            {
                case FeetConvert.Centimeters:
                    double total = value * 30.48;
                    Console.WriteLine(total + " " + FeetConvert.Centimeters);
                    break;

                case FeetConvert.Inches:
                    double total1 = value * 12;
                    Console.WriteLine(total1 + " " + FeetConvert.Inches);
                    break;

                case FeetConvert.Meters:
                    double total2 = value * 0.3048;
                    Console.WriteLine(total2 + " " + FeetConvert.Meters);
                    break;

                case FeetConvert.Millimeters:
                    double total3 = value * 304.8;
                    Console.WriteLine(total3 + " " + FeetConvert.Millimeters);
                    break;

                case FeetConvert.Yards:
                    double total4 = value * 0.33333333333;
                    Console.WriteLine(total4 + " " + FeetConvert.Yards);
                    break;

                default:
                    Console.WriteLine("Ya did good!");
                    break;
            }
        }
    }
}