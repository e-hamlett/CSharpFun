using System;

namespace Lessons
{
    public class FinalizerExample
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public FinalizerExample(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            Console.WriteLine("The names are " + firstName + " and " + secondName);
        }

        ~FinalizerExample()
        {
            System.Diagnostics.Trace.WriteLine("Finalizer is called");
        }
    }
}
