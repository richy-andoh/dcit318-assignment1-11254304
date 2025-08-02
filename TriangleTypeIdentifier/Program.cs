using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangle:");
            Console.Write("Side 1: ");
            bool valid1 = double.TryParse(Console.ReadLine(), out double side1) && side1 > 0;
            Console.Write("Side 2: ");
            bool valid2 = double.TryParse(Console.ReadLine(), out double side2) && side2 > 0;
            Console.Write("Side 3: ");
            bool valid3 = double.TryParse(Console.ReadLine(), out double side3) && side3 > 0;

            if (valid1 && valid2 && valid3)
            {
                if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
                {
                    if (side1 == side2 && side2 == side3)
                        Console.WriteLine("Triangle type: Equilateral");
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                        Console.WriteLine("Triangle type: Isosceles");
                    else
                        Console.WriteLine("Triangle type: Scalene");
                }
                else
                {
                    Console.WriteLine("The entered sides do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter positive numbers for all sides.");
            }
        }
    }
}
