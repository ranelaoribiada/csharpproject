using System;

namespace StudentManagement
{
    // Define the Student class
    public class Student
    {
        // Step 1: Declare properties
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        // Step 2: Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
        }

        // Step 2: Method to check if the student passed
        public bool IsPassed()
        {
            // Logic: Returns true if grade is 75 or higher
            return Grade >= 75.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 3: Create an instance (object) of the Student class
            Student student1 = new Student();

            // Step 4: Assign sample values to properties
            student1.Name = "Marco";
            student1.Age = 20;
            student1.Grade = 85.5;

            // Step 5: Call methods and display results
            student1.DisplayInfo();

            // Determine status based on IsPassed() result
            string status = student1.IsPassed() ? "Passed" : "Failed";
            Console.WriteLine($"Status: {status}");

            // Keep console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}