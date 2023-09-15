//Базовый уровень 29
//Console.Write("введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("введите b:");
//double b = double.Parse(Console.ReadLine());
//Console.Write("введите c:");
//double c = double.Parse(Console.ReadLine());
//double pp = (a + b + c) / 2;
//double s = Math.Sqrt(pp*(pp-a)*(pp-b)*(pp-c));
//Console.WriteLine($"Площадь:{s:F2}");
//Cредний уровень 30
//Console.WriteLine("введите t:");
//double t = double.Parse(Console.ReadLine());
//const float b = 4.2f;
//double a = t+Math.Pow(b, 3);
//double x = t * t * Math.Sqrt(Math.Abs(a + b));
//double y = Math.Pow(Math.Abs(x + a * a), 5);
//Console.WriteLine($"y={y:F2}");
//Высокий уровень 27
Console.Write("введите n:");
int n = int.Parse(Console.ReadLine());
Console.Write("введите a:");
double a = double.Parse(Console.ReadLine());
double R = a / (2 * Math.Sin(Math.PI / n));
double r = a / (Math.Tan(Math.PI / n));
Console.WriteLine($"Радиус описанной:{R:F2}");
Console.WriteLine($"Радиос вписанной:{r:F2}");




