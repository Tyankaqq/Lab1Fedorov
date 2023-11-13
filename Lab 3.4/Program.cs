//высокий 21 вариант
Console.WriteLine("|    fx  |");
double x = 3;


while (x <= 7)
{
    double fx = 0;
    for (int k = 3; k <= 6; k++)
    {
        int factorial = 1;
        for (int i = 1; i <= k + 1; i++) { factorial *= i; }

        fx += (Math.Pow(-3, k + 1) * factorial) / (Math.Pow(x + 5, k + 1));

    }
    Console.WriteLine($"|{fx,8:F2}|");
    x += 0.5;
}
