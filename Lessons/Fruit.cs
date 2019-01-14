using System;
namespace Lessons
{
    public class Fruit
    {
        public virtual void EatFruit()
        {
            Console.WriteLine("That was real good");
            //ThrowFruit();
        }
        //private is only accessible from within the class. as shown above.
        //in order for method to work it must be called here. 
        private void ThrowFruit()
        {
            Console.WriteLine("Launching in 3.. 2.. 1.. Fruit succesfully Thrown");
            Console.WriteLine("Fruit has hit its mark!");
        }
    }
}