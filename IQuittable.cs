using System;

namespace EmployeeConsoleApp
{
    // Defines a contract for quitting behavior
    public interface IQuittable
    {
        // Any class implementing this interface must provide a Quit() method
        void Quit();
    }
}
