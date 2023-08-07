﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChellengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname, char sex, int age, string nameFather) : base(name, surname, sex, age, nameFather)
        {
        }

        public override void SayHello()         //nadpisanie metody wirtualnej
        {
            Console.WriteLine("Cześć");         //to z tej klasy
            base.SayHello();                    //to z klasy bazowej
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new Exception("Podano błędną ocenę, dopuszczalny zakres: 0-100");
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
