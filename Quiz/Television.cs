using System;

namespace Quiz
{
    public abstract class Television
    {
        public string Size { get; set; } = "50 Inch";
        public string Price { get; set; }
        public bool IsMountable { get; set; }
        public int Ports { get; set; } = 6;

        public abstract void TurnOn();
        public abstract void SmartApp();




        public Television(string price, string size) : this(price, size, true, 6)
        {


        }

        public Television(string price, string size, bool isMountable, int ports)
        {
            this.Price = price;
            this.Size = size;
            this.IsMountable = isMountable;
            this.Ports = ports;
        }

        public void Mountability(bool isMountable)
        {
            if (isMountable)
            {
                Console.WriteLine("The TV is mountable.");
            }
            else
            {
                Console.WriteLine("The TV is not mountable.");
            }
        }


    }



}