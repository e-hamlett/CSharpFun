using System;

namespace Lessons
{
    public class Triceratops : Dinosaur
    {
        public override void Drink()
        {
            Console.WriteLine("Triceratops drinks.");
        }

        public override void EatFood()
        {
            Console.WriteLine("Triceratops eats.");
        }

        public override void Smile()
        {
            Console.WriteLine("Triceratops smiles for picture.");
        }

        public override void TakeNap()
        {
            Console.WriteLine("Triceratop lays down to take nap.");
        }

        public override void Move()
        {
            Console.WriteLine("Triceratops moves out of T-Rex line of sight");
        }

        public override void Hide()
        {
            Console.WriteLine("Triceratops hides from predator.");
        }

        public override void StandUp()
        {
            Console.WriteLine(" Triceratops stands.");
        }

        public override void SniffsAir()
        {
            Console.WriteLine("Triceratops sniffs air for predator.");
        }
    }
}