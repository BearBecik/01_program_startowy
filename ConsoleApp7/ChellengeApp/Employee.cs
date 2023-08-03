using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChellengeApp
{
    public class Employee
    {
        public List<int> employee = new List<int>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public Employee(string name, string surname, int age)     //konstruktor
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void countPoint(int credits)
        {
            employee.Add(credits);
        }
    }
}
