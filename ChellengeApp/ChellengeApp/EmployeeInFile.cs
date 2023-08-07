using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChellengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public override event GradeAddedDelegate GradeAdded;
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname, char sex, int age, string nameFather) : base(name, surname, sex, age, nameFather)
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
                using (var writer = File.AppendText(fileName))      //otwarcie pliku strumieniowego, trzeba go potem zamknąć
                {
                    writer.WriteLine(grade);                        //dopisanie wiersza
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Podano błędną daną z poza zakresu 0-100");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                if (result >= float.MinValue && result <= float.MaxValue)
                {
                    AddGrade((float)result);
                }
                else
                {
                    throw new Exception("Podano zby dużą liczbę dla typu float");
                }
            }
            else
            {
                switch (grade)     //symulacja obsługi typu char
                {
                    case "A":
                        AddGrade(100);
                        break;
                    case "B":
                        AddGrade(80);
                        break;
                    case "C":
                        AddGrade(60);
                        break;
                    case "D":
                        AddGrade(40);
                        break;
                    case "E":
                        AddGrade(20);
                        break;
                    default:
                        throw new Exception("Podano błędną ocenę, dopuszczalne wartości?: A-E");
                }
            }
        }

        public override Statistics GetStatistics()
        {
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if ((float.TryParse(line, out float result)) && (result >= 0 && result <= 100))
                        {
                            grades.Add((float)result);
                        }
                        line = reader.ReadLine();
                    }
                }
            }

            var statistics = new Statistics();
            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
