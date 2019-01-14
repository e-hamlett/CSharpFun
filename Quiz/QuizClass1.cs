using System;

namespace Quiz
{
    public class QuizClass1
    {
        public string Grades(char grade)
        {

            switch (grade)
            {
                case 'E':
                    return "Excellent";
                case 'V':
                    return "Very Good";
                case 'G':
                    return "Good";
                case 'A':
                    return "Average";
                case 'F':
                    return "Fail";
                default:
                    return "It is not a valid grade. Please input a valid grade.";
            }
        }

        public string Grades2(char gram)
        {
            string message = " ";
            switch (gram)
            {
                case 'E':
                    message = "Excellent";
                    break;
                case 'V':
                    message = "very Good";
                    break;
                case 'G':
                    message = "Good";
                    break;
                case 'A':
                    message = "Average";
                    break;
                case 'F':
                    message = "Fail";
                    break;
                default:
                    message = "Not a valid grade!";
                    break;
            }
            return message;


        }

        public void DivisibleByThree()
        {
            int x = 0;

            do
            {
                Console.WriteLine(x);
                x = x + 3;
            } while (x < 50);

        }

        public void NewDivisibleByThree()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void NewDivisibleByThree2()
        {
            int i = 0;
            while (i < 50)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        public void NewDivisibleByThree3()
        {
            int i = 0;
            do
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;

            } while (i < 50);
        }

        public void NewDivisibleByThree4()
        {
            int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 3 == 0)
                {
                    Console.WriteLine(values[i]);
                }
            }
        }

        public void NewDivisibleByThree5()
        {
            int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
            foreach (int item in values)
            {
                if (item % 3 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}