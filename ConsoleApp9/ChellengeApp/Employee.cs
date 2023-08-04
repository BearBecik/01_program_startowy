using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChellengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public string Name { get; set; }
        public string Surname { get; set; }
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            //inicjowanie danych
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            //akcja
            foreach (var grade in grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;
            }

            if (grades.Count != 0)
            {
                Math.Round((statistics.Average /= grades.Count), 2);
            }
            else
            {
                statistics.Max = 0;
                statistics.Min = 0;
            }
            return statistics;
        }
    }
}
