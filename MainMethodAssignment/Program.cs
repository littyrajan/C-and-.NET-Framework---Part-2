using System;

class Program
{
    static void Main()
    {
        // Create object of OverloadedMath
        OverloadedMath mathObj = new OverloadedMath();

        // Call method with integer
        int intResult = mathObj.Calculate(15);
        Console.WriteLine($"Integer input 15 + 10 = {intResult}");

        // Call method with decimal
        int decimalResult = mathObj.Calculate(7.5m);
        Console.WriteLine($"Decimal input 7.5 * 2 = {decimalResult}");

        // Call method with string
        int stringResult = mathObj.Calculate("20");
        Console.WriteLine($"String input '20' - 5 = {stringResult}");

        // Keep console open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
