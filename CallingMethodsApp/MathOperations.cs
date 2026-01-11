using System;

namespace CallingMethodsApp
{
    // This class contains three methods that each take an integer and return an integer
    public class MathOperations
    {
        // Method 1: Adds 10 to the input number
        public int AddTen(int number)
        {
            return number + 10; // Return the input plus 10
        }

        // Method 2: Squares the input number
        public int Square(int number)
        {
            return number * number; // Return the input multiplied by itself
        }

        // Method 3: Subtracts 5 from the input number
        public int SubtractFive(int number)
        {
            return number - 5; // Return the input minus 5
        }
    }
}
