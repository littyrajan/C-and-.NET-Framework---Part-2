using System;

// No extra namespace required, or keep both files in the same one
public class OverloadedMath
{
    // Method 1: Takes an integer, adds 10, returns result
    public int Calculate(int number)
    {
        return number + 10;
    }

    // Method 2: Takes a decimal, multiplies by 2, returns result as int
    public int Calculate(decimal number)
    {
        return (int)(number * 2);
    }

    // Method 3: Takes a string, converts to int, subtracts 5, returns result
    public int Calculate(string numberString)
    {
        int number;
        if (int.TryParse(numberString, out number))
        {
            return number - 5;
        }
        else
        {
            Console.WriteLine("Invalid string input. Returning 0.");
            return 0;
        }
    }
}
