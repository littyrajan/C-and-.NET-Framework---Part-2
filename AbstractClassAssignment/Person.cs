using System;

namespace AbstractClassAssignment
{
    // Abstract base class
    public abstract class Person
    {
         // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method — must be overridden in derived classes
        public abstract void SayName();
    }
}
