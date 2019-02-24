using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class DogYearCalculator
    {
        int dogWeight;

        SmallDog sd = new SmallDog();
        MediumDog md = new MediumDog();
        LargerDog ld = new LargerDog();

        public void DogSize()
        {
            Console.WriteLine("Do you want to find out how old your dog is in human years? If so, press Y.");
            Console.ReadLine();
            Console.WriteLine("Please enter your dogs weight.");
            dogWeight = Convert.ToInt32(Console.ReadLine());
        }

        public void calcSelect()
        {
            if (dogWeight <= 20)
            {
                Console.WriteLine("You have a small dog.");
                sd.ReadData();
            }
            else if (dogWeight >= 21 && dogWeight <= 49)
            {
                Console.WriteLine("You have a medium dog");
                md.ReadData();
            }
            else if (dogWeight >= 50)
            {
                Console.WriteLine("You have a Larger dog.");
                ld.ReadData();
            }
            else
            {
                Console.WriteLine("Thanks for asking me to help!");
            }
        }

    }
}
