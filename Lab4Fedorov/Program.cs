Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());

double R = (x * x + y * y );
if (x >= -1 && x <= 1 && y >= 0 && y <= 1 && R >= 1) Console.WriteLine("Входит");

else Console.WriteLine("Не входит");