using System;

namespace Lessons
{
    public class Lesson13
    {
        string _firstName, _secondName;

        public Lesson13(string firstName, string secondName)
        {
            this._firstName = firstName;
            this._secondName = secondName;
            Console.WriteLine("Constructor Called");
            Console.WriteLine(firstName + " " + secondName);

        }

        public void Deconstruct(out string firstName, out string secondName)
        {
            firstName = this._firstName;
            secondName = this._secondName;
            Console.WriteLine("Deconstructor Called");
            Console.WriteLine(_secondName + " " + _firstName);
        }

    }
}
