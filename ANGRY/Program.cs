//Console.Write("введите x:");
//double x = double.Parse(Console.ReadLine());
//if (x > -5 && x < 3) Console.WriteLine("входит");
//else Console.WriteLine("не входит");

//Console.WriteLine("Введите n");
//int n = int.Parse(Console.ReadLine());
//if (n / 10 == 3 || n % 10 == 3) Console.WriteLine("Входит");
//else Console.WriteLine("Не входит");

//Console.Write("введите a");
//double x = double.Parse(Console.ReadLine());
//Console.Write("введите b");
//double b = double.Parse(Console.ReadLine());
//Console.Write("введите c");
//double c = double.Parse(Console.ReadLine());
//double d = b * b - 4 * a * c;
//if (d >0)
//{
//    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//    double x2 = (-b + Math.Sqrt(d)) / (2 * a);
//    Console.WriteLine($"x1 = {x1:F2} x2 = {x2:F2}");
//}
//else if (d == 0)
//{
//    double x = -b / (2 * a);
//    Console.WriteLine($"x={x:F2}");
//}
//else Console.WriteLine("корней нет");




//int i = 5;
//while (i > 0)
//{
//    Console.Write(i);
//    --i;
//};
//Console.Write("Введите n:");
//int n = int.Parse(Console.ReadLine());
//int i = 1;
//long F = 0;
//while (i <= n) F += i++;
//Console.WriteLine($"сумма {n} равен {F}");]
//double a = 5;
//for (int i = 0; i<5;i++)
//{
//    Console.WriteLine(a);
//    a += 2;
//}

//for(int i = 35; i < 88; i++)
//{
//    if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5 ) Console.WriteLine(i); 
//}

//Console.Write("Введите n:");
//int n = int.Parse(Console.ReadLine());
//int s = 0;
//for (int i = 1; i <= n; i++) s += 1;
//Console.WriteLine($"Sum{s}");
//long F = 1;
//for (int i = 1;i <= n; i++) F *= i;
//Console.WriteLine($"Fact{F}")
//for(int i = 0; i < 11; i++)
//{
//    Console.Write(20 +" ");
//}
//Console.Write("Введите число:");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Введите кол-во раз:");
//int m = int.Parse(Console.ReadLine());
//for (int i = 0; i <  m; i++)
//{
//    Console.WriteLine(n + " ");
//}

//for (int i = 21; i < 36; i++)
//{
//    Console.WriteLine($"{i} {i - 0.6}");
//}
//int n = 0;
//do
//{
//    Console.Write("Введите положительное число:");
//    n = int.Parse(Console.ReadLine());
//    if (n <= 0) Console.WriteLine("Введите число больше 0");

//}
//while (n <= 0);
//int s = 0, i = 1;
//do
//{
//    s += i++;
//}   
//while (i <= n);
//Console.WriteLine("S="+ s);
//double x = -2; 
//Console.WriteLine($"|{"x",10} | {"y",10}|");
//do
//{
//    double y = Math.Sin(x) * Math.Tan(2 * x);
//    Console.WriteLine($"|{x,10:F2} | {y,10:F2}|");
//    x+= 0.5;

//}   
//while (x<=2);
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
//Дано натуральное число. Определить:
//a) Кол-во 3 в нем
//б) сколько раз встречается последняя цифра
//в) кол во четных цифр 

//Console.WriteLine("Введите целое число:");
//int n = int.Parse(Console.ReadLine());
//int count3 = 0;
//int last = n % 10;
//int countLast = 0;
//int countOdd = 0;
//int sumGreate5 = 0;
//int multiGereate7 = 1;
//int count5or7 = 0;
//while (n !=0 )
//{
//    int temp = n % 10;
//    if (temp == 3) count3++;
//    if (temp == last) countLast++;
//    if (temp%2 == 0) countOdd++;
//    if (temp > 5) sumGreate5 += temp;
//    if (temp > 7) multiGereate7 += temp;
//    if (temp == 5 || temp == 7) count5or7++;
//    n /= 10;
//}
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//int i = 1000;
//while (i <=9999)//внешний цикл
//{
//    int temp = i;
//    int s = 0;
//    while (temp !=0) //внутренний цикл
//    {
//        s += temp % 10;
//        temp /= 10;
//    }
//    if (s == 15) Console.WriteLine(i + " ");
//    i++;
//}
//Вложенные циклы 8.1
//for (int i = 1; i <= 4; i++)
//{
//    for (int j = 1; j <=6; j++)
//    {
//        Console.Write(5 + " ");
//    }    
//    Console.WriteLine();
//}
//Console.WriteLine();
//8.2
//for (int i = 1;i <= 4; i++)
//{
//    for (int j = 0; i <= 10; j++)
//    {
//        Console.Write(j + " ");
//    }
//}
//8.3 
//for (int i = 40; i < 80; i+=10)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.Write(i+j+" ");
//    }
//    Console.WriteLine();
//}
//for (int i = 1; i <= 5; i++)
//{
//	for (int j = 1; j <= i; j++)
//	{
//        Console.Write(5 + "");
//    }
//    Console.WriteLine();
//}
//for (int i = 5; i >=1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(1 + "");
//    }
//    Console.WriteLine();
//}
//for (int i = 1; i <= 5; i+=1)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(i + j + " ");
//    }
//}
//задача 26
//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    double s = 0;
//    for (int i = 1; i <= n; i++)
//        s += Math.Pow(x, i) * Math.Sin(i * Math.PI / 3) / i;
//    Console.WriteLine($"S={s:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
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

//    Console.WriteLine($"S={s:F2}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//базовый 26
//double x = 0.1;
//Console.Write("|        x       |      y       |");
//while (x <= 3)
//{
//    double y = Math.Sqrt(1 + x) - 3 * Math.Cos(x);
//    Console.WriteLine($"|{x,4:F2}|{y,8:F2}|");
//    x += 0.2;
//}
//средний 26
//Console.WriteLine("|    x   |   y   |");
//for (double x = -Math.PI; x <= Math.PI / 2; x += 0.2)
//{
//    double y;
//    if (x < 0) y = Math.Log(Math.Abs(Math.Sin(x * x)));
//    else if (x >= 0 && x <= 2.5) y = Math.Pow(x, 5);
//    else y = x + 1;
//    Console.WriteLine($"|{x,8:F2}| {y,8:F2}|");
//    
//}
//высокий уровень 26
//Console.WriteLine("|    x   |   y     |");
//for (double x = -Math.PI / 2; x <=2 * Math.PI; x += Math.PI/4)
//{
//    double y;
//    if (x <= Math.PI) y = Math.Pow(Math.Asin(1-Math.Abs(Math.Cos(x*x*x))),Math.Sin(x));
//    else y = Math.Log(Math.Cos(x));
//    Console.WriteLine($"|{x,8:F2}| {y,8:F2}|");
//}
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

        fx += (Math.Pow(-3, k + 1) * factorial) / (Math.Pow(x+5,k +1));
            
    }
    Console.WriteLine($"|{fx,8:F2}|");
    x += 0.5;
}

