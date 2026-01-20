using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main()
        {
            // Ask the user to enter the first name
            Console.WriteLine("Enter a first name:");
            string firstNameInput = Console.ReadLine();

            // Ask the user to enter the last name
            Console.WriteLine("Enter a last name:");
            string lastNameInput = Console.ReadLine();

            // Create and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = firstNameInput,
                LastName = lastNameInput
            };

            // Call the SayName method implemented in Employee
            employee.SayName();

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

