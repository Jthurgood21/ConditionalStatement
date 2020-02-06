using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int userGrade;
            Console.WriteLine("What grade out of 100 do you think you you will recieve in the class?");
            userGrade = Convert.ToInt32(Console.ReadLine());
            if (userGrade >= 98 && userGrade <= 100)
            {
                Console.WriteLine("A+"); 
            }
            else if (userGrade >= 92 && userGrade <= 97)
            {
                Console.WriteLine("A");
            }
            else if (userGrade >= 90 && userGrade <= 91)
            {
                Console.WriteLine("A-");
            }
            else if (userGrade >= 88 && userGrade <= 89)
            {
                Console.WriteLine("B+");
            }
            else if (userGrade >= 82 && userGrade <= 87)
            {
                Console.WriteLine("B");
            }
            else if (userGrade >= 80 && userGrade <= 81)
            {
                Console.WriteLine("B-");
            }
            else if (userGrade >= 78 && userGrade <= 79)
            {
                Console.WriteLine("C+");
            }
            else if (userGrade >= 72 && userGrade <= 77)
            {
                Console.WriteLine("C");
            }
            else if (userGrade >= 70 && userGrade <= 71)
            {
                Console.WriteLine("C-");
            }
            else if (userGrade >= 68 && userGrade <= 69)
            {
                Console.WriteLine("D+");
            }
            else if (userGrade >= 62 && userGrade <= 67)
            {
                Console.WriteLine("D");
            }
            else if (userGrade >= 60 && userGrade <= 61)
            {
                Console.WriteLine("D-");
            }
            else if (userGrade < 60)
            {
                Console.WriteLine("F");
            }
        }
    }
}
