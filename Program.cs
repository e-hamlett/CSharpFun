﻿using System;
using Lessons;
using Quiz;
using Advanced;

namespace CSharpFun
{
    class Program
    {
        public delegate void TryOn(string type);

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
            //CarSample();
            //ReturnGrade();
            //FruitSample();
            //ParamsSample();
            //ModifierExamples();
            //Lesson12();
            //AbstractDemo();
            //Lesson13();
            //FinalizerExample();
            //IndexerSample();
            //PartialSample();
            //AnotherHouseExample();
            //CollectionSample();
            //LabResult();
            //DelegateSample();
            //MultiDelegateSample();
            //EventSample();
            LambdaSample();
        }

        private static void LambdaSample()
        {
            LambdaExamples myLAmbda = new LambdaExamples();

            Console.WriteLine(myLAmbda.MyLambdaOne(5));
            Console.WriteLine(myLAmbda.MyLambdaOne(6));
            Console.WriteLine(myLAmbda.MyLambdaOne(7));
            Console.WriteLine(myLAmbda.MyLambdaOne(8));
            Console.WriteLine(myLAmbda.MyLambdaOne(9));
            Console.WriteLine(myLAmbda.MyLambdaOne(10));

        }


        private static void EventSample()
        {
            Coats myCoat = new Coats();
            string result = myCoat.MyResult;
            Console.WriteLine(result);
        }

        private static void MultiDelegateSample()
        {
            Hats moreHats = new Hats(7);
            TryOn someHat, niceHat, sadHat;

            niceHat = moreHats.FindLuckyHat;
            niceHat("Top");

            sadHat = moreHats.FindUglyHat;
            sadHat("Dunce");

            someHat = sadHat + niceHat;
            someHat("Cowboy");

        }

        static void DelegateSample()
        {
            Hats myHat = new Hats("Cowboy", 7);
            TryOn theHat = myHat.TryOnHat;
            theHat("I can not fit this size of " + myHat.HatType + "; It must be a size " +
            myHat.HatSize);

            Hats mySecondHat = new Hats();
        }

        static void LabResult()
        {
            LabResults lr = new LabResults();
            lr.Question1();
            lr.Question2();
            lr.Question3();
            lr.Question4();
            lr.Question5();
            // lr.Question6();
            lr.Question7();
        }


        static void CollectionSample()
        {
            CollectionExamples myCE = new CollectionExamples();
            myCE.MyArrayListExample();
            myCE.MyListExample();
        }

        static void GenericSample()
        {
            GenericList<int> myList = new GenericList<int>();
            myList.Add(10);

            GenericList<string> mySecondList = new GenericList<string>();
            mySecondList.Add("Happy");

            GenericList<TRex> myTRexList = new GenericList<TRex>();
            myTRexList.Add(new TRex());
        }

        static void AnotherHouseExample()
        {
            House myHouse = new House()
            {
                Roof = "Shingles",
                Foundation = "Concrete",
                Window = "Double Pane",
                PaintDoor = "Dark Navy Blue",
            };
            Console.WriteLine("My window choice is gonna have to be " + myHouse.Window);
        }

        static void PartialSample()
        {
            Pear pear = new Pear("Bartlett Pear");
        }
        static void IndexerSample()
        {
            IndexerExample indexExample = new IndexerExample();
            indexExample[2] = 250;
            for (int i = 0; i < indexExample.Length; i++)
            {
                Console.WriteLine("Value {0} = {1}", i, indexExample[i]);
            }

        }

        static void FinalizerExample()
        {

            FinalizerExample fe = new FinalizerExample("Maliyah", "Ramiyah");


        }

        static void Lesson13()
        {
            String first = "Carl", second = "Hamlett";
            Lesson13 lesson13 = new Lesson13(first, second);
            Console.WriteLine("First Name = {0} and Last Name = {1}", first, second);
            lesson13.Deconstruct(out first, out second);
            Console.WriteLine("Last Name = {1} and First Name = {0}", first, second);


        }
        static void AbstractDemo()
        {
            TRex trex = new TRex();
            Triceratops tri = new Triceratops();
            Archaeopteryx arc = new Archaeopteryx();
            NarratorLizard nl = new NarratorLizard();


        }

        static void Lesson12()
        {
            double temp2 = Utilities.FahrenheitToCelsius("87");
            Console.WriteLine(temp2);
            double temp = Utilities.CelsiusToFahrenheit("30.55555555555556");
            Console.WriteLine(temp);
        }

        static void ModifierExamples()
        {
            int test = 14;
            Lesson011 myLesson = new Lesson011();
            myLesson.RefSample(ref test);
            Console.WriteLine(test);

            String first, middle, second;

            myLesson.OutSample("John Riley Doe", out first, out middle, out second);

            Console.WriteLine(first);
            Console.WriteLine(middle);
            Console.WriteLine(second);
        }

        static void ParamsSample()
        {
            Lesson011 lesson = new Lesson011();
            lesson.UseParams(10, 3, 24, 36, 45, 120);

            lesson.UseParams();

            int[] intArray = { 2, 3, 4, 5, 6 };

            lesson.UseParams(intArray);

            lesson.UseParams2(1, "Happy", false, 34.5F);

            lesson.OptionalParam("Roger O\'dell");
            lesson.OptionalParam("Eugene", 24);

        }

        static void FruitSample()
        {
            Apple myApple = new Apple();
            myApple.EatFruit();

            Fruit myFruit = new Apple();
            myFruit.EatFruit();

            Orange myOrange = new Orange();
            myOrange.EatFruit();

            RanchStyle ranch = new RanchStyle("Stone", "Tripple Pane", "Composite", "Blue");
            ranch.OpenDoor();
            Console.WriteLine("The roof is made of" + " " + ranch.Roof + " material.");
            Console.WriteLine("The foundation is a mixture of Himilayan " + ranch.Foundation + ".");
            Console.WriteLine("The windows are " + ranch.Window + ".");
            Console.WriteLine("The door is painted in Tiffany " + ranch.PaintDoor + ".");
            Console.WriteLine("Does this house spark your interest? If so, we could set up a walk-thru this upcoming Weekend!");

        }

        static void ReturnGrade()
        {
            QuizClass1 qc1 = new QuizClass1();
            string newGrade = qc1.Grades2('D');

            string grade1 = qc1.Grades('E');
            Console.WriteLine(grade1);
            string grade2 = qc1.Grades('V');
            Console.WriteLine(grade2);
            string grade3 = qc1.Grades('G');
            Console.WriteLine(grade3);
            string grade4 = qc1.Grades('A');
            Console.WriteLine(grade4);
            string grade5 = qc1.Grades('F');
            Console.WriteLine(grade5);
            string grade6 = qc1.Grades('S');
            Console.WriteLine(grade6);
            qc1.DivisibleByThree();
            string mygrade = qc1.Grades2('E');
            Console.WriteLine(mygrade);
            qc1.NewDivisibleByThree();
            qc1.NewDivisibleByThree4();
            Console.ReadLine();

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

        // static void HouseSample()
        //{
        //House myHouse = new House("concrete", "triple pane");
        //Console.WriteLine(myHouse.PaintDoor);
        // Console.WriteLine(myHouse.Foundation + " " + myHouse.Window);
        // myHouse.OpenDoor(true);
        // }



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

        // static void MyHouseResults()
        // {
        // House myHouse = new House();
        // myHouse.PaintDoor = "Red";
        // myHouse.CloseDoor();

        //Console.WriteLine(myHouse.PaintDoor);

        // House mySecondHouse = new House();
        //mySecondHouse.PaintDoor = "green";
        //Console.WriteLine(mySecondHouse.PaintDoor);
        // Console.WriteLine(mySecondHouse.PaintDoor);

        //}


    }
}

