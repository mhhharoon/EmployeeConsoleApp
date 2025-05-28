using System;

// Define the IQuittable interface
public interface IQuittable
{
    void Quit();
}

// Employee class inherits from IQuittable interface
public class Employee : IQuittable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement Quit method from IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}

class Program
{
    static void Main()
    {
        // Example usage of polymorphism
        IQuittable employee1 = new Employee { FirstName = "John", LastName = "Doe" };
        employee1.Quit(); // Calls the Quit method overridden in the Employee class

        // Another example
        Employee employee2 = new Employee { FirstName = "Jane", LastName = "Smith" };
        IQuittable employee2AsIQuittable = employee2; // Implicit conversion to IQuittable
        employee2AsIQuittable.Quit(); // Calls the Quit method through IQuittable interface

        // Pause console to view output
        Console.ReadLine();
    }
}
