////объявление массивов
////инициализация при объявлении 
//int[] mas1 = { 1, 3, 5, 7, 9 };
//int[] mas2 = new int[5] { 2, 4, 6, 8, 10 };
////ввод с клавиатуры
//int[] mas3 = new int[5];
//for (int i = 0; i < mas3.Length; i++)
//{
//    mas3[i] =int.Parse(Console.ReadLine());
//}
////вывод с помощью оператора for
//for (int i = 0; i < mas3.Length; i++)
//{
//    Console.Write(mas3[i]+" ");
//}
//Console.WriteLine();
////генерация элементов массива с помощью генератора случайных чисел
//Random random = new Random();
//int[] mas4 = new int[10];
//for (int i = 0;i < mas4.Length; i++)
//{
//    mas4[i]=random.Next(10,100);
//    Console.Write(mas4[i]+" ");
//}
//Console.WriteLine();
////генерация вещественных чисел
//double[] mas5 = new double[10];
//for (int i = 0; i < mas5.Length; i++)
//{
//    mas5[i] =100*random.NextDouble();
//    Console.Write($"{mas5[i]:F2} ");
//}
//Console.WriteLine();
////генерация по формуле
//int[] mas6 = new int[10];
//for (int i = 0; i < mas6.Length; i++)
//{
//    mas6[i] = 2 * i + 1;
//}
//foreach(int i in mas6)
//{
//    Console.Write(i+" ");
//}
//Console.WriteLine();
//основные операции с массивами

using System.Runtime.Serialization.Formatters;
using System.Xml;

//Console.Write("Введите кол во элементов:");
//int n = int.Parse (Console.ReadLine());
//int[] mas = new int[n];
//Random r = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = r.Next(10, 100);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
////задача 11.15(a)
//int m = r.Next(mas.Length);
//Console.WriteLine($"{mas[m]} {Math.Sqrt(mas[m]):F2}");
////задача 11.15(б)
//int a = r.Next(mas.Length);
//int b = r.Next(mas.Length);
//Console.WriteLine($"{(mas[a] + mas[b])/2:F2}");
////11.16a
//int s = r.Next(mas.Length);
//if (mas[s] > 0) Console.WriteLine(">0");
//else Console.WriteLine("<0");
////11.16б
//int k  = r.Next(mas.Length);
//if (mas[k] % 2 == 0) Console.WriteLine("Четное");
//else Console.WriteLine("Нечетное");
////11.16в
//if (mas[k] > mas[s]) Console.WriteLine($"{mas[k]> mas[s]}");
//else if (mas[k] < mas[s]) Console.WriteLine($"{mas[k] < mas[s]}");
//else Console.WriteLine($"{mas[k]}={mas[s]}");
////11.18a
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] -= 20;
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] *= mas[mas.Length-1];
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
////11.19a
//int Sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    Sum += mas[i];
//    Console.WriteLine("Sum=" +Sum );
//}
//Console.WriteLine();
////11.19б
//int P = 1;
//for (int i = 0;i < mas.Length; i++)
//{
//    P*= mas[i];

//}
//Console.WriteLine("P=" +P);
////11.107
//int max = mas[0], min = mas[0];
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i] > max) max = mas[i];
//    if (mas[i] < min) min = mas[i];
//}
//Console.WriteLine("max=" +max);
//Console.WriteLine("min=" +min);
//Console.WriteLine("max-min="+(max-min));
////Сортировка
////1.Пузырьком
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = i+1; j < mas.Length; j++)
//    {
//        if (mas[i] > mas[j])
//        {
//            int temp = mas[i];
//            mas[i] = mas[j];
//            mas[j] = temp;
//        }
//    }
//}
//foreach (int i in mas) Console.WriteLine(i +" ");
//Console.WriteLine();
//11.54а
//Console.WriteLine("Введите размер массива:");
//int n = int.Parse(Console.ReadLine());
//int[] mas  = new int[n];
//Random rand = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rand.Next(0,100);
//    Console.Write(mas[i]+ " ");
//}
//Console.WriteLine();
////11.54a
//int Sum20 = 0;
//for (int i = 0; i < mas.Length; i++)
//    if (mas[i] <= 20) Sum20 += mas[i];
//Console.WriteLine("Sum="+Sum20);
////11.54б
//Console.WriteLine("Введите a:");
//int a = int.Parse(Console.ReadLine());
//int Suma = 0;
//for (int i = 0; i < mas.Length; i++)
//    if (mas[i] > a) Suma += mas[i];
//Console.WriteLine("Sum=" + Suma);
//11.70
//int Sumwin = 0;
//int Sumdraw = 0;
//int[] mas = new int[20];
//Random rand = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rand.Next(0,4);
//    Console.Write(mas[i] + " ");
//}

//Console.WriteLine();
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] == 1) Sumdraw++;
//    if (mas[i] == 3) Sumwin++;
//}
//Console.WriteLine("Sumdraw=" +Sumdraw);
//Console.WriteLine("Sumwin=" +Sumwin);
int[] mas = new int[20];
Random rand = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rand.Next(100, 500);
    Console.Write(mas[i] + " ");
}

Console.WriteLine();
int min = mas[0];
for (int i = 1; i < mas.Length; i++)
{
   if (mas[i] < min) min = mas[i];
}
Console.WriteLine("min:" +min);