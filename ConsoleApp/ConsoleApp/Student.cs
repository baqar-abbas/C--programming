using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Grade> Grades { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            Grades = new List<Grade>();
        }

        public double CalculateAverage()
        {
            if (Grades.Count == 0)
                return 0;

            return Grades.Average(g => g.Score);
        }

        public double CalculateGPA()
        {
            double average = CalculateAverage();

            return average switch
            {
                >= 90 => 4.0,
                >= 80 => 3.0,
                >= 70 => 2.0,
                >= 60 => 1.0,
                _ => 0.0
            };
        }
    }
}
