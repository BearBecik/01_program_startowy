﻿using System;
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

        public Employee()
        {
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

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Podano niewłaściwą wartość z zakresu A-E");
                    break;
            }
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