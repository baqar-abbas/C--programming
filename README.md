# Student Grading System

A console-based student grading management system built with C# and .NET 8 that allows you to track student performance, calculate grades, and generate reports.

## 🎯 Project Overview

A comprehensive system that can:

- ✅ Add students and their grades
- ✅ Calculate averages and letter grades
- ✅ View individual student performance
- ✅ Generate class reports with statistics
- ✅ Save/load data to JSON for persistence

## 🚀 Features

### Student Management

- Add new students with unique IDs
- Store student information (ID, Name)
- Track multiple grades per student

### Grade Management

- Add grades for specific subjects
- Score validation (0-100 range)
- Automatic timestamp recording
- Letter grade calculation (A, B, C, D, F)

### Performance Analytics

- Calculate student average scores
- GPA calculation (4.0 scale)
- Individual student performance reports
- Class-wide statistics and averages

### Data Persistence

- Save all student data to JSON format
- Auto-load data on application startup
- Optional save prompt on exit

## 📋 Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022 (or any C# compatible IDE)

## 🛠️ Installation

1. Clone the repository:

git clone https://github.com/baqar-abbas/C--programming.git
cd C--programming

2. Open the solution in Visual Studio 2022

3. Build the project:

4. Run the application:

## 📖 Usage

### Main Menu Options

=== Student Grading System ===

1. Add Student
2. Add Grade
3. View Student Performance
4. Generate Class Report
5. Save Data
6. Exit

### Example Workflow

1. **Add a Student**
   - Select option 1
   - Enter Student ID (e.g., 101)
   - Enter Student Name (e.g., John Doe)

2. **Add Grades**
   - Select option 2
   - Enter Student ID
   - Enter Subject (e.g., Mathematics)
   - Enter Score (0-100)

3. **View Performance**
   - Select option 3
   - Enter Student ID to see detailed report

4. **Generate Class Report**
   - Select option 4
   - View all students with averages and GPAs

5. **Save Data**
   - Select option 5
   - Data saved to `students.json`

## 📊 Grading Scale

### Letter Grades

| Score Range | Letter Grade |
| ----------- | ------------ |
| 90-100      | A            |
| 80-89       | B            |
| 70-79       | C            |
| 60-69       | D            |
| 0-59        | F            |

### GPA Scale

| Average Score | GPA |
| ------------- | --- |
| 90-100        | 4.0 |
| 80-89         | 3.0 |
| 70-79         | 2.0 |
| 60-69         | 1.0 |
| 0-59          | 0.0 |

## 🏗️ Project Structure

ConsoleApp/ │ ├── Program.cs # Main entry point with menu system ├── Student.cs # Student model with GPA/average calculations ├── Grade.cs # Grade model with letter grade conversion ├── GradeManager.cs # Business logic for student/grade management └── students.json # Data persistence file (auto-generated)

## 💻 Technology Stack

- **Language**: C# 12.0
- **Framework**: .NET 8.0
- **Data Storage**: JSON (System.Text.Json)
- **Architecture**: Object-Oriented Programming (OOP)

## 📝 Code Examples

### Adding a Student

GradeManager manager = new GradeManager(); manager.AddStudent(101, "John Doe");

### Adding a Grade

manager.AddGrade(101, "Mathematics", 95.5);

### Viewing Performance

manager.ViewStudentPerformance(101);

## 🔧 Key Classes

### Student

- Properties: `Id`, `Name`, `Grades`
- Methods: `CalculateAverage()`, `CalculateGPA()`

### Grade

- Properties: `Subject`, `Score`, `DateRecorded`
- Methods: `GetLetterGrade()`

### GradeManager

- Methods: `AddStudent()`, `AddGrade()`, `ViewStudentPerformance()`, `GenerateClassReport()`, `SaveData()`, `LoadData()`

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

## 👨‍💻 Author

**Baqar Abbas**

- GitHub: [@baqar-abbas](https://github.com/baqar-abbas)

## 🐛 Known Issues

- None at the moment

## 📅 Version History

- **v1.0.0** (2026-02-20) - Initial release
  - Basic student and grade management
  - JSON data persistence
  - Performance reporting

---

Made with Microsoft Visual Studio using C# and .NET 8
