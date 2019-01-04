using System;
using System.Text;

namespace Lessons
{
    public class StringTypes
    {
        private string _testString = "Test String";
        private string _secondString = "Second String";

        public void SampleString()
        {
            Console.WriteLine(_testString);
        }

        public void AddString()
        {
            Console.WriteLine(_testString + " " + _secondString);
        }

        public string StringBuilderExample(string value1, string value2, string value3)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(value1)
            .Append(" ").Append(value2)
            .Append(" ").Append(value3);

            return builder.ToString();

        }

        public void CharTypeExamples()
        {
            char ab = 'A'; //character
            char de = 'B'; //character
            char copyrightSymbol = '\u00A9'; //unicode
            char fg = '\x0058'; //hexidecimal
            char hi = (char)88; //Explicit Cast fromm int
            
            Console.WriteLine(hi); //
            Console.WriteLine(ab == de); //false
            //Console.WriteLine("The copyright symbol looks like {0}", copyrightSymbol);
            /*will uncomment above when we comeback to learn about placeholders */
        }


    }
}