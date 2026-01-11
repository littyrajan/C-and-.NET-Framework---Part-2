using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // STRING ARRAY SECTION
            // -------------------------------

            // Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Mango", "Orange" };

            // Ask the user to select an index
            Console.WriteLine("STRING ARRAY");
            Console.WriteLine("Select an index (0 - 4):");

            // Read user input and convert it to an integer
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the index exists in the array
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the string at the selected index
                Console.WriteLine("You selected: " + stringArray[stringIndex]);
            }
            else
            {
                // Display error message if index does not exist
                Console.WriteLine("That index does not exist in the string array.");
            }

            Console.WriteLine(); // Blank line for readability

            // -------------------------------
            // INTEGER ARRAY SECTION
            // -------------------------------

            // Create a one-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index
            Console.WriteLine("INTEGER ARRAY");
            Console.WriteLine("Select an index (0 - 4):");

            // Read user input and convert it to an integer
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the index exists in the array
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                // Display the integer at the selected index
                Console.WriteLine("You selected: " + intArray[intIndex]);
            }
            else
            {
                // Display error message if index does not exist
                Console.WriteLine("That index does not exist in the integer array.");
            }

            Console.WriteLine(); // Blank line for readability

            // -------------------------------
            // STRING LIST SECTION
            // -------------------------------

            // Create a list of strings
            List<string> stringList = new List<string>()
            {
                "Red",
                "Blue",
                "Green",
                "Yellow",
                "Purple"
            };

            // Ask the user to select an index
            Console.WriteLine("STRING LIST");
            Console.WriteLine("Select an index (0 - 4):");

            // Read user input and convert it to an integer
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the index exists in the list
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                // Display the string at the selected index
                Console.WriteLine("You selected: " + stringList[listIndex]);
            }
            else
            {
                // Display error message if index does not exist
                Console.WriteLine("That index does not exist in the list.");
            }

            // Prevent console from closing immediately
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
