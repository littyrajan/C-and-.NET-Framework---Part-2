using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Step 1: Create a one-dimensional array of strings
        string[] myStrings = { "Hello ", "Welcome ", "Goodbye ", "Morning " };

        // Step 2: Ask the user to input some text
        Console.Write("Enter some text to append: ");
        string userInput = Console.ReadLine();

        // Step 3: Loop through each string and append the user's input
        for (int i = 0; i < myStrings.Length; i++)
        {
            myStrings[i] += userInput; // Append the user's text
        }

        // Step 4: Loop again to print each string in the array
        Console.WriteLine("\nUpdated strings:");
        foreach (string str in myStrings)
        {
            Console.WriteLine(str);
        }

        // Step 5: Demonstrate an infinite loop
        /*
        int counter = 0;
        while (true) // This is an infinite loop
        {
            Console.WriteLine("This loop will run forever!");
        }
        */

        // Step 6: Fix the infinite loop so it executes properly
        int counter = 0;
        while (counter < 5) // Fix: set a condition so the loop will eventually stop
        {
            Console.WriteLine("This loop runs 5 times, not forever!");
            counter++; // Increment counter to eventually end the loop
        }

         // Step 6: Another loop using "<=" operator
        int anotherCounter = 0;
        while (anotherCounter <= 5) // "<=" operator loop
        {
            Console.WriteLine("This loop runs 6 times using '<='");
            anotherCounter++;
        }

        // PART 4: List of unique strings
        List<string> myList = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Ask user for input to search in the list
        Console.Write("\nEnter text to search in the list: ");
        string searchInput = Console.ReadLine();

        bool found = false; // Flag to track if a match was found

        // Loop through the list to find the index of matching text
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase)) // Match found
            {
                Console.WriteLine($"Text found at index {i}.");
                found = true;
                break; // Stop the loop once a match is found
            }
        }

        // Check if no match was found
        if (!found)
        {
            Console.WriteLine("Your input is not on the list.");
        }


        // =======================
        // PART 5: List with duplicates and find all matches
        // =======================
        List<string> duplicateList = new List<string> { "Red", "Blue", "Green", "Red", "Yellow", "Blue" };

        Console.Write("\nEnter text to search in the list with duplicates: ");
        string duplicateSearch = Console.ReadLine();

        bool matchFound = false; // Track if any match is found

        // Loop through list to find all matching indices
        for (int i = 0; i < duplicateList.Count; i++)
        {
            if (duplicateList[i].Equals(duplicateSearch, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Text found at index {i}.");
                matchFound = true;
                // No break here, so it finds all matches
            }
        }

        if (!matchFound)
        {
            Console.WriteLine("Your input is not on the list.");
        }


        // =======================
        // PART 6: Detect duplicates while iterating
        // =======================
        List<string> itemsList = new List<string> { "A", "B", "C", "D", "C", "B", "E" };
        HashSet<string> seenItems = new HashSet<string>(); // To track items we've seen

        Console.WriteLine("\nChecking for duplicates in the list:");
        // Loop through each item
        foreach (string item in itemsList)
        {
            if (seenItems.Contains(item)) // If we've seen it before
            {
                Console.WriteLine($"{item} - this item is a duplicate");
            }
            else
            {
                Console.WriteLine($"{item} - this item is unique");
                seenItems.Add(item); // Mark this item as seen
            }
        }


        // Keep the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}