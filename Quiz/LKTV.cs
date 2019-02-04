using System;
namespace Quiz
{
    public class LKTV : Television
    {
        public LKTV(string price, string size) : base(price, size)
        {
            Console.WriteLine("The price of the 4KTV is " + price);
            Console.WriteLine("The size of the TV is " + size);

        }

        public override void SmartApp()
        {
            Console.WriteLine("This 4KTV uses a smart app to turn on.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Must use Smart App in order to turn on and use the TV.");
        }
    }
}