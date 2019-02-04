using System;
using Quiz;

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
            Console.WriteLine("There are " + ports + " ports available on this device.");

            LKTV lKTV = new LKTV("$1250.00", "75\"");
            lKTV.Mountability(true);
            lKTV.TurnOn();
            lKTV.SmartApp();
            Console.WriteLine("There are " + ports + " ports available on this device.");

        }

        public void Question3()
        {

        }


    }
}