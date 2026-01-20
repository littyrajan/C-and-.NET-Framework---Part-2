using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Employee Comparison System ---\n");

            // Instantiate and validate the first employee
            Employee emp1 = CreateEmployee(1);
            
            Console.WriteLine(); // Add a line break

            // Instantiate and validate the second employee
            Employee emp2 = CreateEmployee(2);

            Console.WriteLine("\n--- Comparison Results ---");

            // Use the overloaded "==" operator to compare the two objects
            if (emp1 == emp2)
            {
                Console.WriteLine($"Employee {emp1.Id} and Employee {emp2.Id} are EQUAL.");
            }
            else
            {
                Console.WriteLine($"Employee {emp1.Id} and Employee {emp2.Id} are NOT equal.");
            }

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }

        // Helper method to handle user input and validation
        static Employee CreateEmployee(int employeeNumber)
        {
            Employee emp = new Employee();

            // ID Validation: Ensure the user enters a valid integer
            Console.Write($"Enter ID for Employee {employeeNumber}: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Invalid input. Please enter a numeric ID: ");
            }
            emp.Id = id;

            // FirstName Validation: Ensure the string is not null or empty
            emp.FirstName = GetValidString($"Enter First Name for Employee {employeeNumber}: ");

            // LastName Validation: Ensure the string is not null or empty
            emp.LastName = GetValidString($"Enter Last Name for Employee {employeeNumber}: ");

            return emp;
        }

        // Reusable method to check for empty strings
        static string GetValidString(string prompt)
        {
            string input = "";
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: Name cannot be empty.");
                }
            }
            return input;
        }
    }
}