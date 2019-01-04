using System;
using System.Text;
using CSharpFun;

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
            
        }

        public void EscapeSeqExamples()
        {
            Console.WriteLine("My name is John O\'Conner.");
            Console.WriteLine("This is an \a Alert.");
            Console.WriteLine("Some sort of new line \n that I can not figure out.");
            Console.WriteLine("A sort of tab \t is around here somewhere.");
        }

        public void PlaceHolderExample()
        {
            Console.WriteLine("This string is {0}", "cool");
            Console.WriteLine("We can use ints like {0} and {1}", 15, 10);
            Console.WriteLine("I like {1} more than {0}, but not as much as {2}", "sad", "happy", "bossed up");
        }

        public void ArrayExapmles ()
        {
            string[] cars = new string[3];
            cars[0] = "camaro";
            cars[1] = "mustang";
            cars[2] = "chevelle";
            //or
            string[] names = {"Tom", "Roger", "Matt", "Eugene"};

            Console.WriteLine(cars[2]);
            Console.WriteLine(names[3]);
            Console.WriteLine(cars[1] + " " + cars[2]);
            Console.WriteLine(names[2] + " " + names[0] + " " + names[1]);
        }

        public void MyHouseArray() 
        {
            House house1 = new House();
            house1.PaintDoor = "Green";
            House house2 = new House();
            house2.PaintDoor = "Blue";

            House[] houseList = {house1, house2};

            Console.WriteLine(houseList[0].PaintDoor);
        }

        public void MultiArrayExample() 
        {
            int[,] myIntArray = new int[2,2];
            myIntArray[0,0] = 5;
            myIntArray[0,1] = 10;
            myIntArray[1,0] = 2;
            myIntArray[1,1] = 4;

            Console.WriteLine(myIntArray[1,0]);
            Console.WriteLine(myIntArray[0,1]);
            Console.WriteLine(myIntArray[1,1]);
            Console.WriteLine(myIntArray[0,0]);
        }

        public void JaggedArrayExample() 
        {
            //int[,] sampleJagged = new int [2][];
            //sampleJagged[0] = new int[] {2,3,4}; //int[3]
            //sampleJagged[1] = new int[] {5,6};
            //or
            //int[][] secondSample = new int[][]
            //{
                //new int[]{1, 2, 3, 4, 5},
                //new int[]{6, 7, 8, 9},
                //new int[]{10, 11, 12}
            //};

            
        }


    }
}