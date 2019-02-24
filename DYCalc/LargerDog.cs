using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class LargerDog
    {
        int dogAge;
        int humanAge;

        public void ReadData()
        {
            Console.WriteLine("You must have a larger dog.");
            Console.WriteLine("Now that we know the size. We need one more thing.");
            Console.WriteLine("How old is your dog in Human Years?");
            dogAge = Convert.ToInt32(Console.ReadLine());
        }

        public void DoggyYears()
        {
            if (dogAge == 1)
            {
                humanAge = dogAge + 15;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 2)
            {
                humanAge = (dogAge + 13) + 9;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 3)
            {
                humanAge = ((dogAge + 12) + 9) + 4;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 4)
            {
                humanAge = ((dogAge + 10) + 9) + (4 * 2);
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 5)
            {
                humanAge = ((dogAge + 10) + 9) + (4 * 3);
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 6)
            {
                humanAge = ((dogAge + 9) + 9) + (4 * 4) + 5;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 7)
            {
                humanAge = ((dogAge + 8) + 9) + (4 * 5) + 6;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 8)
            {
                humanAge = ((dogAge + 7) + 9) + (4 * 6) + 7;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 9)
            {
                humanAge = ((dogAge + 6) + 9) + (4 * 7) + 9;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 10)
            {
                humanAge = ((dogAge + 5) + 9) + (4 * 8) + 10;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 11)
            {
                humanAge = ((dogAge + 4) + 9) + (4 * 9) + 12;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 12)
            {
                humanAge = ((dogAge + 3) + 9) + (4 * 10) + 13;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 13)
            {
                humanAge = ((dogAge + 2) + 9) + (4 * 11) + 14;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 14)
            {
                humanAge = ((dogAge + 1) + 9) + (4 * 12) + 16;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 15)
            {
                humanAge = (dogAge + 9) + (4 * 13) + 17;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            else if (dogAge == 16)
            {
                humanAge = ((dogAge - 1) + 9) + (4 * 14) + 40;
                Console.WriteLine("Your dog is " + humanAge + " in Dog Years!");
            }
            Console.ReadLine();
        }
    }
}
