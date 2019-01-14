using System;
namespace Lessons
{
    // Apple extends the functionality of Fruit class
    public class Apple : Fruit
    {
        public override void EatFruit()
        {
            Console.WriteLine("I eat apples.");
        }
    }
}