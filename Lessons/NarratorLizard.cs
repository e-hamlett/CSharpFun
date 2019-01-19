using System;

namespace Lessons
{
    public class NarratorLizard : Dinosaur
    {
        public override void Drink()
        {
            Console.WriteLine("Hello, this tory is about a T-Rex, and his daring attempt at life" + "."
+ "Which an ancient winged bird can not allow to happen for reasons unknown. -Sips tea");
        }

        public override void EatFood()
        {
            Console.WriteLine("Observe how each animal can detect the other nearby, what will they do?");
        }

        public override void Smile()
        {
            Console.WriteLine("Thats right. They all instinctively make their moves.");
        }

        public override void SniffsAir()
        {
            Console.WriteLine("-sniffing the air, The quality is much better in this time period. You know, less of us and all that jazz.");
        }

        public override void StandUp()
        {
            Console.WriteLine("Let me get out of the way. Maybe I should yell timber.");
        }

        public override void TakeNap()
        {
            Console.WriteLine("-Yawns, Im ready to go, are you? ok, lets get back. wooaaahh.");
        }

        public override void Crouch()
        {
            Console.WriteLine("I better get down under this elphant ear like plant beside me. That way our Ancient flying friend misses me.");
        }
    }
}