using System;

namespace OperatorsAssignment
{using System;
  public class Employee
    {
        // Properties to store Employee data
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the "==" operator to compare Employee objects by their ID
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both point to the same memory address, they are equal
            if (ReferenceEquals(emp1, emp2)) return true;

            // If one is null but the other isn't, they are not equal
            if (emp1 is null || emp2 is null) return false;

            // Return true if IDs match, otherwise false
            return emp1.Id == emp2.Id;
        }

        // Overloading the "!=" operator (required when "==" is overloaded)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Simply returns the logical opposite of the "==" operator
            return !(emp1 == emp2);
        }

        // Overriding Equals to ensure consistency with the "==" operator
        public override bool Equals(object obj)
        {
            if (obj is Employee emp) return this.Id == emp.Id;
            return false;
        }

        // Overriding GetHashCode to match the Equals logic (ID-based)
        public override int GetHashCode() => Id.GetHashCode();
    }
}