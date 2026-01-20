using System;

// Static class (cannot be instantiated)
public static class MathUtility
{
    // VOID method that accepts an integer
    // Divides the number by 2 and outputs the result
    public static void DivideByTwo(int number)
    {
        // Perform division by 2
        int result = number / 2;

        // Display the result to the screen
        Console.WriteLine($"Result from void method: {result}");
    }

    // OVERLOADED method with an output parameter
    // This method also divides the number by 2
    public static void DivideByTwo(int number, out int result)
    {
        // Store the result in the output parameter
        result = number / 2;
    }
}
