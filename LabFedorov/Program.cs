Console.Write("введите z:");
double z = double.Parse(Console.ReadLine());
Console.Write("введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("введите a:");
double a = double.Parse(Console.ReadLine());
double N = (Math.Pow(Math.Sqrt(z + Math.Sqrt(z * x)), 1 / 5.0)) / (Math.Exp(x)+Math.Pow(a, 5));
Console.WriteLine($"N ={N:F2}");


