using System;
using System.Collections.Generic;
using System.Collections;
namespace Lessons
{
    public class CollectionExamples
    {
        public void MyListExample()
        {
            List<Dinosaur> myDinos = new List<Dinosaur>();
            myDinos.Add(new TRex());
            myDinos.Add(new TRex() { Travel = "Stomp" });
            myDinos.Add(new Triceratops() { Travel = "Trample" });

            foreach (Dinosaur dinosaur in myDinos)
            {
                Console.WriteLine("These dinos travel by {0}", dinosaur.Travel);
                Console.WriteLine(dinosaur);
            }
        }

        public void MyArrayListExample()
        {
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add("Hello");
            myArrayList.Add("World");
            myArrayList.Add(42);
            myArrayList.Add("84");
            myArrayList.Add("67");

            Console.WriteLine("Count = {0}", myArrayList.Count);

            myArrayList.Remove(42);
            myArrayList.RemoveAt(0);

            Console.WriteLine("Count = {0}", myArrayList.Count);

            myArrayList.Add("Other");
            myArrayList.Add("Stuff");
            myArrayList.Sort();

            foreach (Object item in myArrayList)
            {
                Console.WriteLine("Type = {0}", item);
            }
        }
    }
}