using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     class Employee
    {
        public List<int> wynik = new List<int>();
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public int Wiek { get; private set; }
        
        public Employee(string imie, string nazwisko, int wiek)     //konstruktor
        { 
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }
        public void Zlicz(int punkty)
        {
            wynik.Add(punkty);
        }
    }
}
