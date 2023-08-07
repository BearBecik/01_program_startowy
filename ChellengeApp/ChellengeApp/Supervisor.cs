using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChellengeApp.EmployeeBase;

namespace ChellengeApp
{
    public class Supervisor : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public override event GradeAddedDelegate GradeAdded;

        public Supervisor(string name, string surname, char sex, int age, string nameFather) : base(name, surname, sex, age, nameFather)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            Age = age;
            NameFather = nameFather;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }
        public int Age { get; private set; }
        public string NameFather { get; private set; }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Podano błędną daną z poza zakresu 0-100");
            }
        }

        public override void AddGrade(string grade)
        {
            grade = grade.Replace("+", "").Trim();
            if (grade.Length == 2 && grade[1] == '-')
            {
                grade = "-" + grade.Substring(0, 1);
            }
            if (int.TryParse(grade, out int note))
            {
                switch (note)
                {
                    case 6:
                        AddGrade(100);
                        break;
                    case 5:
                        AddGrade(80);
                        break;
                    case 4:
                        AddGrade(60);
                        break;
                    case 3:
                        AddGrade(40);
                        break;
                    case -3:
                        AddGrade(35);
                        break;
                    case 2:
                        AddGrade(25);
                        break;
                    case -2:
                        AddGrade(20);
                        break;
                    case 1:
                        AddGrade(0);
                        break;
                    default:
                        throw new Exception("Podano błędną ocenę, oczekuje się ocen z zakresu 1-6");
                }
            }
            else
            {
                throw new Exception("Podano błędną ocenę, oczekuje się ocen z zakresu 1-6");
            }
        }

        public override Statistics GetStatistics()
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

                switch (statistics.Average)
                {
                    case var average when average >= 80:
                        statistics.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        statistics.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        statistics.AverageLetter = 'D';
                        break;
                    default:
                        statistics.AverageLetter = 'E';
                        break;
                }
            }
            else
            {
                statistics.Max = 0;
                statistics.Min = 0;
                statistics.AverageLetter = 'z';
            }
            return statistics;
        }
    }
}
