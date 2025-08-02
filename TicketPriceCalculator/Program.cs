using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
            {
                int price = (age <= 12 || age >= 65) ? 7 : 10;
                Console.WriteLine($"Ticket price: GHC{price}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
