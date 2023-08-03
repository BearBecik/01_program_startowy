string name = "Ewa";
string gender = "K";
int age = 30;

if (name == "Ewa" && age == 30)
{
    Console.WriteLine($"mam na imę {name} w wieku {age} lat");
}
else if (gender == "K" && age < 30)
{
    Console.WriteLine($"Jestem Kobietą poniżej {age} lat");
}
else
{
    Console.WriteLine($"Nie jestem Kobietą poniżej {age} lat");
}
// cz.II zmiana płci
name = "Arek";
gender = "M";
age = 17;
if (gender == "M" && age < 18)
{
    Console.WriteLine("Niepelnoletni mężczyzna");
}
else if (gender == "M")
{
    Console.WriteLine($"Mężczyzną o imieniu {name}");
}
