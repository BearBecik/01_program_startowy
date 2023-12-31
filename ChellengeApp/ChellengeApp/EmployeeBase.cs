﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChellengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);  // to alias to metody

        public abstract event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname, char sex, int age, string nameFather)
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
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(string grade);
        public abstract Statistics GetStatistics();
    }
}
