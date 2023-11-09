
//средний уровень 21 задание
try
{
    Console.Write("Введите k:");
    int k = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    int x = int.Parse(Console.ReadLine());
    double P = 1;
    double S = 0;
    
    for (int t = 2; t <= k; t++)
    {
        if (t != 3) P = t * Math.Pow(x, t) / t - 3;
        for (int i = 1; i <= t; i++)
        {
            if (i != 7) S += (i - 2) / (i - 7);
        }
    }
    Console.WriteLine($"P={P * S:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}





