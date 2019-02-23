using System;
using StructQ5;


namespace Quiz
{
    public class LabResults
    {


        public void Question1()
        {
            int myVal1 = 600, myVal2 = 25, myVal3 = 0;


            int resistance = myVal1 / myVal2;

            Console.WriteLine("The resistance of the object is " + resistance);

            myVal3 = resistance;
            int voltage = myVal2 * myVal3;
            int current = myVal1 / myVal3;

            Console.WriteLine("The voltage of the object is " + voltage);
            Console.WriteLine("The current of the object is " + current);

        }

        public void Question2()
        {
            int ports = 5;
            HDTV hDTV = new HDTV("$700.00", "65 Inch");
            hDTV.TurnOn();
            hDTV.Mountability(true);
            Console.WriteLine("There are " + hDTV.ports + " ports available on this device.");

            LKTV lKTV = new LKTV("$1250.00", "75\"");
            lKTV.Mountability(true);
            lKTV.TurnOn();
            lKTV.SmartApp();
            Console.WriteLine("There are " + ports + " ports available on this device.");

        }

        public void Question3()
        {
            FeetConversion fc = new FeetConversion();
            fc.ConversionFeet(12.0, FeetConversion.FeetConvert.Centimeters);
            fc.ConversionFeet(1.1, FeetConversion.FeetConvert.Inches);
            fc.ConversionFeet(13.5, FeetConversion.FeetConvert.Meters);
            fc.ConversionFeet(16.3, FeetConversion.FeetConvert.Millimeters);
            fc.ConversionFeet(15.4, FeetConversion.FeetConvert.Yards);
        }

        public void Question4()
        {
            LeapYear lyr = new LeapYear();
            lyr.readdata();
            lyr.leap();
        }

        public void Question5()
        {
            TV1 tV1 = new TV1();
            tV1.price = "$7000.00";
            tV1.size = "75 Inch";
            tV1.ports = 5;
            tV1.isMountable = true;

            Console.WriteLine("The price of the HDTV is  {0} ", tV1.price);
            Console.WriteLine("The size of the HDTV is " + tV1.size);
            Console.WriteLine("The number of ports of the HDTV is " + tV1.ports);
            Console.WriteLine("Is the TV Mountable " + tV1.isMountable);
        }

        public void Question6()
        {
            DogYears dogYears = new DogYears();
            dogYears.ReadData();
            dogYears.DoggyYears();
        }


    }
}