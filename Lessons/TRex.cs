using System;

namespace Lessons
{
    public class TRex : Dinosaur
    {
        public override void Drink()
        {
            Console.WriteLine("T-Rex Drinks.");
        }

        public override void EatFood()
        {
            Console.WriteLine("T-Rex eats his prey. Licking his fingers and rubbing his chest.");
        }

        public override void Move()
        {
            Console.WriteLine("T-Rex runs shaking the ground as he goes.");
        }

        public override void Smile()
        {
            Console.WriteLine("T-Rex shows his sharp teeth. As if other dinosaurs cared.");
        }

        public override void TakeNap()
        {
            Console.WriteLine("T-Rex takes nap when he wants to cause hes the King.");
        }

        public override void Attack()
        {
            Console.WriteLine("T-Rex violently attacks his prey.");
        }

        public override void StandUp()
        {
            Console.WriteLine("The T-Rex stands up.");
        }

        public override void SniffsAir()
        {
            Console.WriteLine("The T-Rex sniffs air for prey.");
        }
        public override void Crouch()
        {
            Console.WriteLine("The T-Rex crouchs behind the trees.");
        }
    }
}