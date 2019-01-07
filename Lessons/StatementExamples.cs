using System;

namespace Lessons
{
    public class StatementExamples
    {

        public void SampleIf()
        {
            int num = 10;
            if (num > 9) ;
            {
                Console.WriteLine("If statement was vaild");
            }
            Console.WriteLine("After If Statement");
        }

        public void SampleIfElse()
        {
            int value = 15;
            Console.WriteLine("Before if Statement");
            if (value >= 15)
            {
                Console.WriteLine("If Statement Executes");
            }
            else
            {
                Console.WriteLine("Else Statement Executes");
            }
            Console.WriteLine("After If Statemnet");
        }

        public void SampleIfChain()
        {
            int num = 15;
            Console.WriteLine("Before if Statement");
            if (num > 15)
            {
                Console.WriteLine("If Statement Executes");
            }
            else if (num == 15)
            {
                Console.WriteLine("Else If Statement Executes");
            }
            else
            {
                Console.WriteLine("Else Statement Executes");
            }
            Console.WriteLine("After If Statement");
        }

        public void SampleIfAnd()
        {
            int num1 = 15, num2 = 20;
            Console.WriteLine("Before If Statement");
            if (num1 < 20 && num2 > 19)
            {
                Console.WriteLine(" If Statement");
            }
            else
            {
                Console.WriteLine("Else Executes");
            }
            Console.WriteLine("After If Statement");
        }

        public void SampleIfOr()
        {
            int num1 = 15, num2 = 20;
            Console.WriteLine("Before If Statement");
            if (num2 > 25 || num1 = 15)
            {
                Console.WriteLine("If Statement Executes");
            }
            else
            {
                Console.WriteLine("Else Statement Executes");
            }
            Console.WriteLine("After If Statement");
        }

        public void SampleConditional()
        {
            int num = 20;
            string word = (num < 25) ? "its less" : "its more";
            Console.WriteLine(word);
        }

        public void SapmleSwitch(int num)
        {
            switch (num)
            {
                case 1:
                case 5:
                    Console.WriteLine("5 was chosen");
                    break;
                case 10:
                    Console.WriteLine("10 was chosen");
                    break;
                case 15:
                    Console.WriteLine("15 was chosen");
                    break;
                case 20:
                    Console.WriteLine("20 was chosen");
                    break;
                default:
                    Console.WriteLine("No correct number was chosen");
                    break;
            }
        }

        public void SampleWhile()
        {
            int num = 0;
            while (num < 10)
            {
                Console.WriteLine("Number = {0}", num);
                num++;
            }
        }

        public void SampleDoWhile()
        {
            int num = 0; 
            do
            {
                Console.WriteLine("Number = {0}", num);
                num++;
            } while (num < 10);
        }

    }
}