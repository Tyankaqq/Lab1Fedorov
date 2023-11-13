//Высокий уровень 21 задание 
int n = 1000;

while (n <= 9999)
{
    int g = n;

    int a = g / 1000;
    g = g % 1000;
    int b = g / 100;
    g = g % 100;
    int c = g / 10;
    int d = g % 10;

    if (a != b && a != c && a != d && b != c && b != d && c != d)
    {
        Console.WriteLine(n);

    }
    n++;
}