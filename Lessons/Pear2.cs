using System;
namespace Lessons
{
    //File name Pear2
    public partial class Pear
    {
        public Pear(string message, string something)
        {
            Console.WriteLine(message + " is " + something);
            Peel();

        }

        partial void Peel()
        {
            Console.WriteLine("I peeled a pear");
        }

        partial void Color()
        {
            Console.WriteLine(" The color of a Bartlett Pear is yellow-green.");
        }
    }
}