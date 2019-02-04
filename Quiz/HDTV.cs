using System;

namespace Quiz
{
    public class HDTV : Television
    {
        public int ports = 7;
        public HDTV(string price, string size) : base(price, size)
        {
            Console.WriteLine("The price of the HDTV is " + price);
            Console.WriteLine("The size available for the HDTV is " + size);
        }




        public override void SmartApp()
        {
            Console.WriteLine("Cannot use a smart app with this TV.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Must use the provided remote to Turn On TV.");
        }
    }
}