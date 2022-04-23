using System;

namespace ADO_Connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ADO.net Program");
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();
            Employee.AddEmployee(employee);
            repo.Employee();
        }
    }
}
