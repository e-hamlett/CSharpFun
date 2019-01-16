using System;

namespace Lessons
{
    public class Lesson011
    {
        public void UseParams(params int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

        public void UseParams2(params object[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

        public void OptionalParam(string name, int age = 45)
        {
            Console.WriteLine(name + " is " + age + " years old.");

        }

        public void RefSample(ref int value)
        {
            value = value + 5;
            Console.WriteLine(value);
        }

        public void OutSample(string name, out string firstName, out string middle, out string lastName)
        {
            int myIndex = name.LastIndexOf(' ');
            firstName = name.Substring(0, myIndex);

            string otherName = name.Substring(myIndex + 1);
            int myOther = otherName.LastIndexOf(' ');

            middle = otherName.Substring(0, myOther);
            lastName = otherName.Substring(myOther + 1);

        }


    }
}