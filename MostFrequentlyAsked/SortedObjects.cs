using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class SortedObjects
    {
        public static void Run()
        {
            Console.WriteLine("==> Sort a List of Objects Using LINQ <==");

            //Creating Objects
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Salary = 5000 },
                new Employee { Id = 2, Name = "Bob", Salary = 4000 },
                new Employee { Id = 3, Name = "Charli", Salary = 6000 }
            };

            var sortedEmployees = employees.OrderBy( x => x.Salary);

            Console.WriteLine($"Id\tName\tSalary");
            foreach (Employee employee in sortedEmployees)
            {
                Console.WriteLine($"{employee.Id}\t{employee.Name}\t{employee.Salary}");
            }

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
    }
}
