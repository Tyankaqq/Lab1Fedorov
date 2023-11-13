//задание 21
try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            s += Math.Pow(x, 2 * i + 1) / 2 * i + 1;
        }
        else
        {
            s -= -Math.Pow(x, 2 * i + 1) / 2 * i + 1;
        }
    }
    Console.WriteLine($"s={s:F2}");
}
catch (Exception ex)
{
   Console.WriteLine(ex.Message);
}
