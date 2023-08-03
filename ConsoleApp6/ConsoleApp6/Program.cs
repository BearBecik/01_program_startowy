using ConsoleApp6;
using System.Xml;

Employee prac1 = new Employee("Arkadiusz", "Bett", 56);
Employee prac2 = new Employee("Magdalena", "Kowalska", 26);
Employee prac3 = new Employee("Zbigniew", "Malinowski", 37);

prac1.Zlicz(3);
prac1.Zlicz(2);
prac1.Zlicz(10);
prac1.Zlicz(3);
prac1.Zlicz(10);

prac2.Zlicz(2);
prac2.Zlicz(8);
prac2.Zlicz(7);
prac2.Zlicz(6);
prac2.Zlicz(1);

prac3.Zlicz(1);
prac3.Zlicz(6);
prac3.Zlicz(4);
prac3.Zlicz(8);
prac3.Zlicz(3);

int max = -1;

////rozwiązanie pierwotne (samodzielne)
/////użyłem tablicy z sumą wyników, aby dla mnie kod był czytelniejszy
int[] Wynik = new int[3];

Wynik[0] = prac1.wynik.Sum();
Wynik[1] = prac2.wynik.Sum();
Wynik[2] = prac3.wynik.Sum();

if (Wynik[0] > Wynik[1] && Wynik[1] > Wynik[2]) { max = 0; }
else if (Wynik[1] > Wynik[0] && Wynik[1] > Wynik[2]) { max = 1; }
else if (Wynik[2] > Wynik[0] && Wynik[0] > Wynik[1]) { max = 2; }
if (max == 0) { Console.WriteLine($"'Samodzielne' - najlepszym wynikiem {Wynik[max]} pkt może pochwalić się {prac1.Imie} {prac1.Nazwisko} - {prac1.Wiek} lat"); }
else if (max == 1) { Console.WriteLine($"'Samodzielne' - najlepszym wynikiem {Wynik[max]} pkt może pochwalić się {prac2.Imie} {prac2.Nazwisko} - {prac2.Wiek} lat"); }
else if (max == 2) { Console.WriteLine($"'Samodzielne' - najlepszym wynikiem {Wynik[max]} pkt może pochwalić się {prac3.Imie} {prac3.Nazwisko} - {prac3.Wiek} lat"); }
else Console.WriteLine("'Samodzielne' - Jest co najmniej 2-ch pracowników o tej samej liczbie punktów");

//rozwiązanie z podpowiedzią Adama
List<Employee> pracownicy = new List<Employee>();
pracownicy.Add(prac1);
pracownicy.Add(prac2);
pracownicy.Add(prac3);

max = -1;
Employee maxPrac = null;

foreach (var prac in pracownicy)
{
    if (prac.wynik.Sum() > max)
    {
        max = prac.wynik.Sum();
        maxPrac = prac;
    }
}
Console.WriteLine();
Console.WriteLine($"'Pętla foreach' - najlepszym wynikiem {max} pkt może pochwalić się {maxPrac.Imie} {maxPrac.Nazwisko} w wieku {maxPrac.Wiek} lat");
