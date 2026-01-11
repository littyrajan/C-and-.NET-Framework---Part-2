using System;

namespace CallingMethodsApp
{
    class Program
    {
        static void Main()
        {
            // =======================
            // Step 1: Ask user for a number
            // =======================
            Console.Write("Enter a number to perform math operations on: ");
            string userInput = Console.ReadLine(); // Read user input as string

            // Convert the input string to integer
            int number;
            if (!int.TryParse(userInput, out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return; // Stop execution if input is invalid
            }

            // =======================
            // Step 2: Create an object of MathOperations class
            // =======================
            MathOperations mathOps = new MathOperations();

            // =======================
            // Step 3: Call each method and display results
            // =======================
            int result1 = mathOps.AddTen(number); // Add 10
            Console.WriteLine($"{number} + 10 = {result1}");

            int result2 = mathOps.Square(number); // Square the number
            Console.WriteLine($"{number} squared = {result2}");

            int result3 = mathOps.SubtractFive(number); // Subtract 5
            Console.WriteLine($"{number} - 5 = {result3}");

            // =======================
            // Step 4: Keep console open
            // =======================
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
