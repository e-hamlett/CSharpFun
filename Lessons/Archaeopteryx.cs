using System;

namespace Lessons
{
    public class Archaeopteryx : Dinosaur
    {
        public override void Drink() { Console.WriteLine("The Archaeopteryx drinks."); }
        public override void EatFood() { Console.WriteLine("The Archaeopteryx eats food curiously."); }
        public override void Smile() { Console.WriteLine("The Archaeopteryx smiles intentively."); }
        public override void SniffsAir() { Console.WriteLine("The Archaeopteryx sniffs the surrounding air for scents of food or predators."); }
        public override void StandUp() { Console.WriteLine("The Archaeopteryx stands up."); }
        public override void TakeNap() { Console.WriteLine("The Archaeopteryx lays down to take a nap."); }
        public override void Move() { Console.WriteLine("The Archaeopteryx walks slowly away."); }
        public override void Attack() { Console.WriteLine("The Archaeopteryx bites and violently attacks with its beak and talons."); }
        public override void Crouch() { Console.WriteLine("The Archaeopteryx crouchs close to the ground."); }
    }
}