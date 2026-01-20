using System;

namespace AbstractClassAssignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
