//Console.Write("Введите номер дня:");
//int n = int.Parse(Console.ReadLine());


//int m = (n % 7); 
//if (n >= 1 && n <= 31) Console.WriteLine("Январь");
//else if (n >= 32 && n <= 58) Console.WriteLine("Февраль");
//else if (n >= 59 && n <= 89) Console.WriteLine("Март");
//else if (n >= 90 && n <= 119) Console.WriteLine("Апрель");
//else if (n >= 120 && n <= 150) Console.WriteLine("Май");
//else if (n >= 151 && n <= 180) Console.WriteLine("Июнь");
//else if (n >= 181 && n <= 211) Console.WriteLine("Июль");
//else if (n >= 212 && n <= 242) Console.WriteLine("Август");
//else if (n >= 243 && n <= 272) Console.WriteLine("Сентябрь");
//else if (n >= 273 && n <= 303) Console.WriteLine("Октябрь");
//else if (n >= 304 && n <= 333) Console.WriteLine("Ноябрь");
//else if (n >= 334 && n <= 365) Console.WriteLine("Декабрь");


//switch (m)
//{
//    case 1: Console.WriteLine("Понедельник"); break;
//    case 2: Console.WriteLine("Вторник"); break;
//    case 3: Console.WriteLine("Среда"); break;
//    case 4: Console.WriteLine("Четверг"); break;
//    case 5: Console.WriteLine("Пятница"); break;
//    case 6: Console.WriteLine("Суббота"); break;
//    case 7: Console.WriteLine("Воскресенье"); break;

//    default : Console.WriteLine("Такой масти нет"); break;
//}


//using System.Numerics;

//Console.Write("Введите n:");
//int n = int.Parse(Console.ReadLine());
//switch(n)
//{
//    case 1:
//        {
//            int a = 46, b = 74
//            Console.WriteLine($"Произведение цифр{ a* b}");
//        }
//        break;
//    case 1:
//        {
//            int a = 46, b = 74
//            Console.WriteLine($"Произведение цифр{a * b}");
//        }
//        break;
//    case 1:
//        {
//            int a = 46, b = 74
//            Console.WriteLine($"Произведение цифр{a * b}");
//        }
//        break;
//    case 1:
//        {
//            int a = 46, b = 74
//            Console.WriteLine($"Произведение цифр{a * b}");
//        }
//        break;
//    case 1:
//        {
//            int a = 46, b = 74
//            Console.WriteLine($"Произведение цифр{a * b}");
//        }
//        break;
//}



//средний уровень 26
using System.ComponentModel.Design;
using System.Transactions;

Console.Write("Введите n:");
int n  = int.Parse(Console.ReadLine());
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
switch (n)
{
    case 1:
        {
            double z = Math.Asin(Math.Pow(x, 3));
            double y;
            if (z > -0.5) y = (2 * z + 1) * (2 * z + 1) / (3.71 - x * x);
            else if (z > -0.5 && z <= 1E-3) y = Math.Pow(Math.Sin(z), 3) - Math.Sin(z / 3 * Math.PI);
            else y = (Math.Tan(z + x) - Math.Exp(x)) / (3.5 * x);

            Console.WriteLine($"y={y:F2}");
        } break;
    case 2: break;
    case 3: break;
}    