using System;

namespace SimpleInterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            decimal principal, rate, time, simpleInterest;

            // Get principal amount from user
            Console.Write("Enter the principal amount: ");
            principal = Convert.ToDecimal(Console.ReadLine());

            // Get rate of interest from user
            Console.Write("Enter the rate of interest (in %): ");
            rate = Convert.ToDecimal(Console.ReadLine());

            // Get time period from user
            Console.Write("Enter the time period (in years): ");
            time = Convert.ToDecimal(Console.ReadLine());

            // Calculate simple interest
            simpleInterest = (principal * rate * time) / 100;

            // Display the result
            Console.WriteLine($"\nThe Simple Interest is: {simpleInterest:C}");

            // Wait for user input to close the console
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

