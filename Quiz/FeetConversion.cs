using System;

namespace Quiz
{
    public class FeetConversion
    {
        public enum FeetConvert { Centimeters, Inches, Meters, Millimeters, Yards }

        public void ConversionFeet(double value, FeetConvert feetConvert)
        {
            switch (feetConvert)
            {
                case FeetConvert.Centimeters:
                    double total = Math.Round((value * 30.48), 2);
                    Console.WriteLine(value + " feet is equal to " + total + " " + FeetConvert.Centimeters);
                    break;

                case FeetConvert.Inches:
                    double total1 = Math.Round((value * 12), 2);
                    Console.WriteLine(value + " feet is equal to " + total1 + " " + FeetConvert.Inches);
                    break;

                case FeetConvert.Meters:
                    double total2 = Math.Round((value * 0.3048), 2);
                    Console.WriteLine(value + " feet is equal to " + total2 + " " + FeetConvert.Meters);
                    break;

                case FeetConvert.Millimeters:
                    double total3 = Math.Round((value * 304.8), 2);
                    Console.WriteLine(value + " feet is equal to " + total3 + " " + FeetConvert.Millimeters);
                    break;

                case FeetConvert.Yards:
                    double total4 = Math.Round((value * 0.33333333333), 2);
                    Console.WriteLine(value + " feet is equal to " + total4 + " " + FeetConvert.Yards);
                    break;

                default:
                    Console.WriteLine("Ya did good!");
                    break;
            }
        }
    }
}