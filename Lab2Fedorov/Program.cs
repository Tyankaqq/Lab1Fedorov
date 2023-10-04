
Console.Write("введите x:");
double x = double.Parse(Console.ReadLine());
double sh_x = (Math.Exp(x) - Math.Exp(-x)) / 2;
double y = sh_x * Math.Tan(x + 1) - Math.Pow(Math.Tan(2 + Math.Sinh(x - 1)), 2);
Console.WriteLine($"Значение функции {y:F2}");