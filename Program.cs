using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company("Toon World", new DateTime(1990, 4, 16));

            // Create three employees
Employee employee1 = new Employee{ FirstName = "Yugi", LastName = "Moto", Title="Pharoah", StartDate = new DateTime(2000, 5, 27)};
Employee employee2 = new Employee{ FirstName = "Seto", LastName = "Kaiba", Title="Rival", StartDate = new DateTime(2000, 5, 26)};
Employee employee3 = new Employee{ FirstName = "Maximillion", LastName = "Pegasus", Title="Lunatic", StartDate = new DateTime(1999, 1, 1)};
            // Assign the employees to the company
            myCompany.Employees.Add(employee1);
            myCompany.Employees.Add(employee2);
            myCompany.Employees.Add(employee3);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
foreach (Employee employee in myCompany.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {myCompany.Name} as {employee.Title} since {employee.StartDate.ToShortDateString()}.");
            }

        }
    }
}
