
using System;
namespace Lessons
{
    //File name Pear
    public partial class Pear
    {
        public Pear(string message)
        {
            Console.WriteLine(message);
            Peel();
            Color();
        }

        partial void Peel();

        partial void Color();



    }
}