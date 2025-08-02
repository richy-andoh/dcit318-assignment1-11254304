using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
            {
                switch (grade)
                {
                    case >= 90:
                        Console.WriteLine("Letter grade: A");
                        break;
                    case >= 80:
                        Console.WriteLine("Letter grade: B");
                        break;
                    case >= 70:
                        Console.WriteLine("Letter grade: C");
                        break;
                    case >= 60:
                        Console.WriteLine("Letter grade: D");
                        break;
                    default:
                        Console.WriteLine("Letter grade: F");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }
    }
}
