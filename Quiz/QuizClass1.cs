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

        public void DivisibleByThree()
        {
            int x = 0;

            do
            {
                Console.WriteLine(x);
                x = x + 3;
            } while (x < 50);

        }
    }
}