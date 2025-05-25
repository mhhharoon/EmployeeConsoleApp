using System;

namespace EmployeeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate first Employee and set properties
            Employee emp1 = new Employee
            {
                Id = 101,
                FirstName = "Alice",
                LastName = "Johnson"
            };

            // Instantiate second Employee and set properties
            Employee emp2 = new Employee
            {
                Id = 102,
                FirstName = "Bob",
                LastName = "Smith"
            };

            // Compare using overloaded == operator
            bool areEqual = emp1 == emp2;
            Console.WriteLine($"emp1 == emp2? {areEqual}");  
            // Output: emp1 == emp2? False

            // Compare using overloaded != operator
            bool areNotEqual = emp1 != emp2;
            Console.WriteLine($"emp1 != emp2? {areNotEqual}");
            // Output: emp1 != emp2? True

            // Now set emp2.Id = 101 to show equality
            emp2.Id = 101;
            Console.WriteLine("\nAfter setting emp2.Id = 101:");

            Console.WriteLine($"emp1 == emp2? {emp1 == emp2}");  // True
            Console.WriteLine($"emp1.Equals(emp2)? {emp1.Equals(emp2)}");  // True

            // Wait for key press before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
