int number = 944000235;
string numberString = number.ToString();
char[] chars = numberString.ToCharArray();
int[] wynik = new int[10];

for (int i = 0; i < chars.Length; i++)
{
    if (chars[i] == '0')
    {
        wynik[0]++;
    }
    else if (chars[i] == '1')
    {
        wynik[1]++;
    }
    else if (chars[i] == '2')
    {
        wynik[2]++;
    }
    else if (chars[i] == '3')
    {
        wynik[3]++;
    }
    else if (chars[i] == '4')
    {
        wynik[4]++;
    }
    else if (chars[i] == '5')
    {
        wynik[5]++;
    }
    else if (chars[i] == '6')
    {
        wynik[6]++;
    }
    else if (chars[i] == '7')
    {
        wynik[7]++;
    }
    else if (chars[i] == '8')
    {
        wynik[8]++;
    }
    else if (chars[i] == '9')
    {
        wynik[9]++;
    }
}

Console.WriteLine($"w podanej liczbie {number} jest:");
for (int i = 0; i < wynik.Length; i++)
{
    if (wynik[i] != 0) { Console.WriteLine($"{wynik[i]} x '{i}'"); }
}

