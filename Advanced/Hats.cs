using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    class Hats
    {
        public delegate void TryHat(string type);
        public string HatType { get; }
        public int HatSize { get; }
        public Hats()
        {
            TryHat myHat = TryOnHat;
            TryALargerHat("Fedora", 7, myHat);
        }
        public Hats(int size)
        {
            this.HatSize = size;
        }
        public Hats(string type, int size)
        {
            this.HatSize = size;
            this.HatType = type;
        }
        public void TryOnHat(string message)
        {
            Console.WriteLine(message);
        }

        public void TryALargerHat(string type, int oldSize, TryHat another)
        {
            another("I tried on a " + type + " hat with a size of " + (oldSize + 1).ToString());
        }
        public void FindLuckyHat(string message)
        {
            Console.WriteLine("My Lucky Hat is {0}", message);
        }
        public void FindUglyHat(string message)
        {
            Console.WriteLine("My Ugly Hat is {0}", message);
        }
    }
}
