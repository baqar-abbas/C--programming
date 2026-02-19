using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Grade
    {
        public string Subject { get; set; }
        public double Score { get; set; }
        public DateTime DateRecorded { get; set; }

        public Grade(string subject, double score)
        {
            Subject = subject;
            Score = score;
            DateRecorded = DateTime.Now;
        }

        public string GetLetterGrade()
        {
            return Score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
        }
    }
}
