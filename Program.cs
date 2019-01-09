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
            //OtherNumericExamples();
            //MyStringExamples();
            //StatementSamples();
            //BottlesSong();
            //HouseSample();
            //StructSample();
            CarSample();

        }

        static void CarSample()
        {
            Car sampleCar = new Car("carbon", "steel");
            Console.WriteLine(sampleCar.Hood);
            Console.WriteLine(sampleCar.Seats);
            Console.WriteLine(sampleCar.Trunk);

        }

        static void StructSample()
        {
            BookSample bookSample = new BookSample(4.98m, "Zombie Fallout", "Mark Tufo");
            Console.WriteLine("The book " + bookSample.title + " by " + bookSample.author + " is $" + bookSample.price);
        }

        static void HouseSample()
        {
            House myHouse = new House("concrete", "triple pane");
            Console.WriteLine(myHouse.PaintDoor);
            Console.WriteLine(myHouse.Foundation + " " + myHouse.Window);
            myHouse.OpenDoor(true);
        }



        static void BottlesSong()
        {
            BottlesOfBeer bob = new BottlesOfBeer();
            string song = bob.BottlesOfBeerSong();
            Console.WriteLine(song);
        }


        static void StatementSamples()
        {
            StatementExamples se = new StatementExamples();
            //se.SampleIf();
            //se.SampleIfElse();
            //se.SampleIfChain();
            //se.SampleIfAnd();
            //se.SampleIfOr();
            //se.SampleConditional();
            //se.SapmleSwitch(10);
            //se.SampleWhile();
            //se.SampleDoWhile();
            //se.SampleFor();
            //se.SampleForEach();
            //string myString3 = se.SampleJumpStatement("Monday");
            //Console.WriteLine(myString3);
            //string myString = se.SampleJumpStatement("Thursday");
            //Console.WriteLine(myString);
            //string myString1 = se.SampleJumpStatement("Friday");
            //Console.WriteLine(myString1);
            se.SampleDays(DaysOfWeek.Wed);
        }

        static void MyStringExamples()
        {
            StringTypes myTypes = new StringTypes();
            myTypes.SampleString();
            myTypes.AddString();
            string words = myTypes.StringBuilderExample("Geno is the man!", "C Sharp Class is fun.", "Stay in school kids.");

            Console.WriteLine(words);
            myTypes.CharTypeExamples();
            myTypes.EscapeSeqExamples();
            myTypes.PlaceHolderExample();
            myTypes.ArrayExapmles();
            myTypes.MyHouseArray();
            myTypes.MultiArrayExample();
            //myTypes.JaggedArrayExample();

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

