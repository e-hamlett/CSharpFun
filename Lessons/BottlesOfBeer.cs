using System;

namespace Lessons
{
    public class BottlesOfBeer
    {
        public string BottlesOfBeerSong()
        {
            int beerNum = 99;
            string word = "bottles", result = "";

            while (beerNum > 0)
            {
                if (beerNum == 1)
                {
                    word = "bottle";
                }
                Console.WriteLine(beerNum + " " + word + " of Beer on the wall!");
                Console.WriteLine(beerNum + " " + word + " of Beer!");
                Console.WriteLine("Take one down!");
                Console.WriteLine("Pass it around!");

                beerNum--;
                if (beerNum > 0)
                {
                    Console.WriteLine(beerNum + " " + word + " of Beer on the wall!");
                }
                else
                {
                    result = "no more bottles of Beer on the wall!";
                }
            }
            return result;
        }
    }
}