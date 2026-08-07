using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class GroupData
    {
        public static void Run()
        {
            Console.WriteLine("==> Group Data using LINQ <==");

            //Creating Objects
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Grade = "A" },
                new Student { Name = "Rayan", Grade = "B" },
                new Student { Name = "Collen", Grade = "A" },
                new Student { Name = "Charlie", Grade = "C" },
                new Student { Name = "Rafi", Grade = "C" },
                new Student { Name = "Bob", Grade = "A" },
            };

            //Categorize them into key-value pairs
            var groupedStudents = students.GroupBy( x => x.Grade );

            foreach (var grade in groupedStudents)
            {
                Console.WriteLine($"Group: {grade.Key}");
                foreach (var student in grade)
                {
                    Console.Write($"{student.Name}\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }

    public class Student
    {
        public string? Name { get; set; }
        public string? Grade { get; set; }
    }
}
