using System;
using Lessons;

namespace CSharpFun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello C#!");
            //MyHouseResults();
            //MyNumericExamples();
            OtherNumericExamples();
        }

        static void MyNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.GetSomeType();

            int something = myTypes.ConvertFloatToInt(35.9F);
            Console.WriteLine(something);

            Console.WriteLine(myTypes.LongFromInt(5600));
            myTypes.BasicMath();
            myTypes.CheckOperators();
            myTypes.IncrementDecrement();
            myTypes.SpecialValues();
            myTypes.ComparisonOperators();
    
        }

        static void OtherNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();

            myTypes.OtherOperators();

        }

        static void MyHouseResults()
        {
            House myHouse = new House();
            myHouse.PaintDoor = "Red";
            myHouse.CloseDoor();

            Console.WriteLine(myHouse.PaintDoor);

            House mySecondHouse = new House();
            mySecondHouse.PaintDoor = "green";
            Console.WriteLine(mySecondHouse.PaintDoor);
            Console.WriteLine(mySecondHouse.PaintDoor);

        }


    }
}

