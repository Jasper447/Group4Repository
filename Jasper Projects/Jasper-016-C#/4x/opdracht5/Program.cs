using System;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade did you get? In whole numbers");
            int score = Convert.ToInt32(Console.ReadLine());
            string grade = "";
            switch (score)
            {
                case 11:
                    grade = "A";
                    break;
                case 10:
                    grade = "A-";
                    break;
                case 9:
                    grade = "B+";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "B-";
                    break;
                case 6:
                    grade = "C+";
                    break;
                case 5:
                    grade = "C";
                    break;
                case 4:
                    grade = "C-";
                    break;
                case 3:
                    grade = "D+";
                    break;
                case 2:
                    grade = "D";
                    break;
                case 1:
                    grade = "D-";
                    break;
                default:
                    grade = "F";
                    break;
            }
            Console.WriteLine("Your grade is " + grade);
        }
    }
}
