using System;
using System.Collections.Generic; // Needed for List<>

class Program
{
    static void Main()
    {
        // =======================
        // Step 1: Create a list of integers
        // =======================
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // =======================
        // Step 2: Ask the user for a number to divide by
        // =======================
        Console.Write("Enter a number to divide each number in the list by: ");
        string userInput = Console.ReadLine(); // Read input as string

        try
        {
            // =======================
            // Step 3: Convert user input to a number
            // =======================
            double divisor = Convert.ToDouble(userInput); // May throw FormatException if input is not a number

            // =======================
            // Step 4: Loop through the list and divide each number
            // =======================
            foreach (int num in numbers)
            {
                double result = num / divisor; // May throw DivideByZeroException if divisor is 0
                Console.WriteLine($"{num} divided by {divisor} = {result}");
            }
        }
        catch (FormatException ex) // Handles input that is not a number
        {
            Console.WriteLine($"Error: Invalid input. Please enter a number. Details: {ex.Message}");
        }
        catch (DivideByZeroException ex) // Handles division by zero
        {
            Console.WriteLine($"Error: Cannot divide by zero. Details: {ex.Message}");
        }
        catch (Exception ex) // Handles any other unexpected errors
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        // =======================
        // Step 5: Code after try/catch block
        // =======================
        Console.WriteLine("\nThe program has emerged from the try/catch block and continued execution.");
        Console.WriteLine("Program finished successfully.");

        // Keep the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
