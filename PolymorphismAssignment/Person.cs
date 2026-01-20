namespace PolymorphismAssignment
{
    // Abstract base class Person
    public abstract class Person
    {
        // Properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Abstract method to display full name
        public abstract void SayName();
    }
}
