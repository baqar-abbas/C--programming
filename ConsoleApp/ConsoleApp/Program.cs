// See https://aka.ms/new-console-template for more information
using ConsoleApp;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Project Overview
//A system that can:
//•	Add students and their grades
//•	Calculate averages and letter grades
//•	View student performance
//•	Generate class reports
//•	Save / load data to JSON

GradeManager manager = new GradeManager();
manager.LoadData();

bool running = true;

while (running)
{
    Console.WriteLine("\n=== Student Grading System ===");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Add Grade");
    Console.WriteLine("3. View Student Performance");
    Console.WriteLine("4. Generate Class Report");
    Console.WriteLine("5. Save Data");
    Console.WriteLine("6. Exit");
    Console.Write("\nEnter your choice: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter Student ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.Write("Enter Student Name: ");
                string? name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    manager.AddStudent(id, name);
                }
                else
                {
                    Console.WriteLine("Invalid name!");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID!");
            }
            break;

        case "2":
            Console.Write("Enter Student ID: ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {
                Console.Write("Enter Subject: ");
                string? subject = Console.ReadLine();
                Console.Write("Enter Score (0-100): ");
                if (double.TryParse(Console.ReadLine(), out double score) && !string.IsNullOrWhiteSpace(subject))
                {
                    manager.AddGrade(studentId, subject, score);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID!");
            }
            break;

        case "3":
            Console.Write("Enter Student ID: ");
            if (int.TryParse(Console.ReadLine(), out int viewId))
            {
                manager.ViewStudentPerformance(viewId);
            }
            else
            {
                Console.WriteLine("Invalid ID!");
            }
            break;

        case "4":
            manager.GenerateClassReport();
            break;

        case "5":
            manager.SaveData();
            break;

        case "6":
            Console.Write("Save data before exiting? (y/n): ");
            if (Console.ReadLine()?.ToLower() == "y")
            {
                manager.SaveData();
            }
            running = false;
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid choice! Please try again.");
            break;
    }
}
