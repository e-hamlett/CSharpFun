using System;

namespace CSharpFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#!");
            MyHouseResults();
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
