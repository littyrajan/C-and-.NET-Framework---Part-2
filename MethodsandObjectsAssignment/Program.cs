using System;


class Program
{
    static void Main()
    {
        // Ask the user to enter the first name
            Console.WriteLine("Enter a first name:");
            string firstName = Console.ReadLine();

            // Ask the user to enter the last name
            Console.WriteLine("Enter a last name:");
            string lastName = Console.ReadLine();

            // Create and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Id = 1
            };

            // Call the SayName() method inherited from Person
            employee.SayName();


        // Keep the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
