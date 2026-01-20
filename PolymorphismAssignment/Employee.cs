using System;

namespace PolymorphismAssignment
{
    // Employee class inherits from Person (from previous assignment) and implements IQuittable
    public class Employee : Person, IQuittable
    {
        // Override SayName method from Person
        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        // Implement Quit() method from IQuittable interface
        public void Quit()
        {
            // Display a message indicating the employee has quit
            Console.WriteLine($"{firstName} {lastName} has quit the job.");
        }
    }
}
