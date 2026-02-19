using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    internal class GradeManager
    {
        private List<Student> students;
        private const string FilePath = "students.json";

        public GradeManager()
        {
            students = new List<Student>();
        }

        public void AddStudent(int id, string name)
        {
            if (students.Any(s => s.Id == id))
            {
                Console.WriteLine("Student with this ID already exists!");
                return;
            }

            students.Add(new Student(id, name));
            Console.WriteLine($"Student {name} added successfully!");
        }

        public void AddGrade(int studentId, string subject, double score)
        {
            var student = students.FirstOrDefault(s => s.Id == studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }

            if (score < 0 || score > 100)
            {
                Console.WriteLine("Score must be between 0 and 100!");
                return;
            }

            student.Grades.Add(new Grade(subject, score));
            Console.WriteLine($"Grade added for {student.Name} in {subject}: {score}");
        }

        public void ViewStudentPerformance(int studentId)
        {
            var student = students.FirstOrDefault(s => s.Id == studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }

            Console.WriteLine($"\n--- Performance Report for {student.Name} (ID: {student.Id}) ---");
            Console.WriteLine($"{"Subject",-20} {"Score",-10} {"Letter Grade",-15} {"Date"}");
            Console.WriteLine(new string('-', 70));

            foreach (var grade in student.Grades)
            {
                Console.WriteLine($"{grade.Subject,-20} {grade.Score,-10:F2} {grade.GetLetterGrade(),-15} {grade.DateRecorded:yyyy-MM-dd}");
            }

            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Average Score: {student.CalculateAverage():F2}");
            Console.WriteLine($"GPA: {student.CalculateGPA():F2}");
            Console.WriteLine();
        }

        public void GenerateClassReport()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students in the system!");
                return;
            }

            Console.WriteLine("\n--- Class Report ---");
            Console.WriteLine($"{"ID",-10} {"Name",-20} {"Avg Score",-15} {"GPA",-10} {"Total Grades"}");
            Console.WriteLine(new string('-', 70));

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id,-10} {student.Name,-20} {student.CalculateAverage(),-15:F2} {student.CalculateGPA(),-10:F2} {student.Grades.Count}");
            }

            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Total Students: {students.Count}");
            Console.WriteLine($"Class Average: {students.Average(s => s.CalculateAverage()):F2}");
            Console.WriteLine();
        }

        public void SaveData()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(students, options);
                File.WriteAllText(FilePath, jsonString);
                Console.WriteLine("Data saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }

        public void LoadData()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string jsonString = File.ReadAllText(FilePath);
                    students = JsonSerializer.Deserialize<List<Student>>(jsonString) ?? new List<Student>();
                    Console.WriteLine($"Data loaded successfully! {students.Count} students found.");
                }
                else
                {
                    Console.WriteLine("No saved data found. Starting fresh.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
        }
    }
}
