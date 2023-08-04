using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else Console.WriteLine("Podano błędną daną z poza zakresu 0-100");
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);                 //przywołanie właściwej metody bez konieczności przepisywanie kodu
            }
            else Console.WriteLine("Nie podano wartości liczbowej");
        }

        public void AddGrade(char grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                AddGrade(result);
            }
            else Console.WriteLine("Nie podano wartości liczbowej");
        }

        public void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }

        public void AddGrade(decimal grade)
        {
            AddGrade((float)grade);
        }


        //założenie, że nie wiem, jakie maksymalne wartości mają poniższe typy zmiennych
        public void AddGrade(long grade)
        {
            if (grade >= float.MinValue && grade <= float.MaxValue)
            {
                AddGrade((float)grade);
            }
            else MessageError();
        }
        public void AddGrade(ulong grade)
        {
            if (grade >= float.MinValue && grade <= float.MaxValue)
            {
                AddGrade((float)grade);
            }
            else MessageError();
        }
        public void AddGrade(double grade)
        {
            if (grade >= float.MinValue && grade <= float.MaxValue)
            {
                AddGrade((float)grade);
            }
            else MessageError();
        }

        private void MessageError()
        {
            Console.WriteLine("Podano zby dużą liczbę dla typu float");
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

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


        public Statistics GetStatisticsForEach()
        {
            var statistics = new Statistics();
            //inicjowanie danych
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
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
        public Statistics GetStatisticsFor()
        {
            var statistics = new Statistics();
            //inicjowanie danych
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            //foreach (var grade in grades)
            for (int i = 0; i < grades.Count; i++)
            {
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Average += grades[i];
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

        public Statistics GetStatisticsWhile()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            int index = 0;
            while (index < grades.Count)
            {
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Average += grades[index];
                index++;
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

        public Statistics GetStatisticsDoWhile()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            int index = 0;
            if (grades.Count > 0)
            {
                do
                {
                    statistics.Min = Math.Min(statistics.Min, grades[index]);
                    statistics.Max = Math.Max(statistics.Max, grades[index]);
                    statistics.Average += grades[index];
                    index++;

                } while (index < grades.Count);
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
