using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        struct Student
        {
            public int StudentID;
            public string Name;
            public int Grade;
        }
        static void Main(string[] args)
        {
            // Path to the students.txt file
            string filePath = @"D:\Mphasis\Live Session\Git Project\student_data.txt";

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: student_data.txt file not found.");
                return;
            }

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Skip the header line (StudentID,Name,Grade)
            for (int i = 1; i < lines.Length; i++)
            {
                string[] studentData = lines[i].Split(',');

                // Assuming the data is correctly formatted in the file
                int studentID = int.Parse(studentData[0]);
                string name = studentData[1];
                int grade = int.Parse(studentData[2]);

                // Create a Student object
                Student student = new Student
                {
                    StudentID = studentID,
                    Name = name,
                    Grade = grade
                };

                // Display student data
                Console.WriteLine($" Student ID: {student.StudentID}\n Name: {student.Name}\n Grade: {student.Grade}\n");
            }
            Console.ReadKey();
        }
    }
}
