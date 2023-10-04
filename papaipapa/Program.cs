using System.Security.Cryptography.X509Certificates;

Console.Write("Введите а:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b:");
int b = Convert.ToInt32(Console.ReadLine());
int s = a + b;
Console.WriteLine($"{a}+{b}={s}");
//double d = int.Parse(Console.ReadLine());
//Console.Write("Введите а:");
//float a = float.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//float b = Convert.ToSingle(Console.ReadLine());
//float s = a + b;
//Console.WriteLine($"{a}+{b}={s}");
int x = 56;
long y = a;
short sh = (short)x;//явное преобразование
short d = 257;
byte e = (byte)d;
Console.WriteLine(e);
