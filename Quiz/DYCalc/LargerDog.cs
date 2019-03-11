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

            switch (dogAge)
            {
                case 1:
                    humanAge = dogAge + 14;
                    Console.WriteLine("Your dog is " + humanAge);
                    break;
                case 2:
                    humanAge = (dogAge + 13) + 9;
                    Console.WriteLine("Your dog is " + humanAge);
                    break;
                case 3:
                    humanAge = ((dogAge + 12) + 9) + 4;
                    Console.WriteLine("Your dog is " + humanAge);
                    break;
                case 4:
                    humanAge = ((dogAge + 11) + 9) + (4 * 2);
                    Console.WriteLine("Your dog is " + humanAge);
                    break;
                case 5:
                    humanAge = ((dogAge + 10) + 9) + (4 * 3);
                    Console.WriteLine("Your dog is " + humanAge);
                    break;
                case 6:
                    humanAge = ((dogAge + 9) + 9) + (4 * 4) + 2 + 3;
                    Console.WriteLine("Your dog is " + humanAge);
                    break;
                case 7:
                    humanAge = ((dogAge + 8) + 9) + (4 * 5) + 3 + 3;
                    Console.WriteLine("Your dog is " + humanAge);
                    break;
                case 8:
                    humanAge = ((dogAge + 7) + 9) + (4 * 6) + 3 + 4;
                    Console.WriteLine("your dog is " + humanAge);
                    break;
                case 9:
                    humanAge = ((dogAge + 6) + 9) + (4 * 7) + 4 + 5;
                    Console.WriteLine("your dog is " + humanAge);
                    break;
                case 10:
                    humanAge = ((dogAge + 5) + 9) + (4 * 8) + 4 + 6;
                    Console.WriteLine("Your dog is " + humanAge);
                    break;
                case 11:
                    humanAge = ((dogAge + 4) + 9) + (4 * 9) + 5 + 7;
                    Console.WriteLine("your dog is " + humanAge);
                    break;
                case 12:
                    humanAge = ((dogAge + 3) + 9) + (4 * 10) + 5 + 8;
                    Console.WriteLine("your dog is " + humanAge);
                    break;
                case 13:
                    humanAge = ((dogAge + 2) + 9) + (4 * 11) + 6 + 8;
                    Console.WriteLine("your dog is " + humanAge);
                    break;
                case 14:
                    humanAge = ((dogAge + 1) + 9) + (4 * 12) + 6 + 10;
                    Console.WriteLine("your dog is " + humanAge);
                    break;
                case 15:
                    humanAge = ((dogAge + 9) + (4 * 13) + 7) + 12;
                    Console.WriteLine("your dog is " + humanAge);
                    break;
                case 16:
                    humanAge = ((dogAge - 1) + (4 * 14) + 9) + 40;
                    Console.WriteLine("your dog is " + humanAge);
                    break;

                default:
                    //if there was a need for default this is where it would be placed.
                    break;
            }
            Console.ReadLine();
        }
    }
}
