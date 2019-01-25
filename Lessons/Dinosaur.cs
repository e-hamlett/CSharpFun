using System;

namespace Lessons
{
    public abstract class Dinosaur : IPrehistoric
    {
        public string Travel { get; set; } = "Walk";
        public abstract void EatFood();
        public abstract void Drink();
        public abstract void TakeNap();
        public abstract void Smile();
        public abstract void StandUp();
        public abstract void SniffsAir();

        public virtual void Attack()
        {
            Console.WriteLine("The dinosaur attacks.");
        }

        public virtual void Hide()
        {
            Console.WriteLine("The dinosaur hides.");
        }

        public virtual void Move()
        {
            Console.WriteLine("The Dinosaur moves.");
        }

        public virtual void Climb()
        {
            Console.WriteLine("The dinosaur climbs object.");
        }

        public virtual void Swim()
        {
            Console.WriteLine("The Dinosaur swims.");
        }

        public virtual void Swing()
        {
            Console.WriteLine("The dinosaur swings.");
        }

        public virtual void Crouch()
        {
            Console.WriteLine("The dinosaur crouchs.");
        }
    }
}