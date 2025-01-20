using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StudentDatabaseApp
{
    // Student class
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    // Database context
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection string for local SQLite database
            optionsBuilder.UseSqlite("Data Source=students.db");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentDbContext())
            {
                // Ensure database is created
                db.Database.EnsureCreated();

                Console.WriteLine("Welcome to the Student Database App\n");

                // Add some initial students if the database is empty
                if (!db.Students.Any())
                {
                    Console.WriteLine("Adding initial students to the database...");
                    db.Students.AddRange(new List<Student>
                    {
                        new Student { Name = "Lora", Age = 8, Email = "lora@laskay.com" },
                        new Student { Name = "Theo", Age = 12, Email = "theo@laskay.com" },
                        new Student { Name = "Zoey", Age = 14, Email = "zoey@laskay.com" }
                    });
                    db.SaveChanges();
                }

                // Display all students
                Console.WriteLine("\nCurrent students in the database:");
                foreach (var student in db.Students)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Email: {student.Email}");
                }

                // Add a new student
                Console.WriteLine("\nEnter the name of a new student:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the age of the new student:");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the email of the new student:");
                string email = Console.ReadLine();

                var newStudent = new Student { Name = name, Age = age, Email = email };
                db.Students.Add(newStudent);
                db.SaveChanges();

                Console.WriteLine("\nStudent added successfully!\n");

                // Display updated student list
                Console.WriteLine("Students in the database:");
                foreach (var student in db.Students)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Email: {student.Email}");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
