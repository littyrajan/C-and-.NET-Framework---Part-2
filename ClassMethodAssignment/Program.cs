using System;

class Program
{
    static void Main()
    {
        // Ask the user to enter a number
        Console.WriteLine("Enter a number:");

        // Read the user input from the console
        int userNumber = Convert.ToInt32(Console.ReadLine());

        // Call the void method that divides the number by 2
        // This method prints the result directly
        MathUtility.DivideByTwo(userNumber);

        // Call the overloaded method that uses an output parameter
        int result;
        MathUtility.DivideByTwo(userNumber, out result);

        // Display the output parameter result
        Console.WriteLine($"Using output parameter: {result}");

        // Keep the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
