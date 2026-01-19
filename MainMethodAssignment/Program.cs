using System;

class Program
{
    static void Main()
    {
        // Instantiate (create an object of) the MathOperations class
        MathOperations mathObj = new MathOperations();

        // Call the method by passing values in normal order
        mathObj.ProcessNumbers(10, 5);

        // Call the method again using named parameters
        mathObj.ProcessNumbers(secondNumber: 20, firstNumber: 7);

        // Keeps the console window open until a key is pressed
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
