using System;

// This class contains math-related operations
public class MathOperations
{
    // Void method that takes two integer parameters
    public void ProcessNumbers(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer
        int result = firstNumber * 2;

        // Display the result of the math operation
        Console.WriteLine($"First number multiplied by 2: {result}");

        // Display the second integer to the screen
        Console.WriteLine($"Second number is: {secondNumber}");
    }
}
