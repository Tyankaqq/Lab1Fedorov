//Высокий уровень 23 вариант
Console.Write("Введите размер массива:");
int n = int.Parse(Console.ReadLine());
int[] mas = new int[n];
Random rnd = new Random();
for (int i = 0; i < mas.Length; i++)
{

    mas[i] = rnd.Next(10, 100);
    Console.WriteLine(Convert.ToString(mas[i], 2) + " ");
}
int max = mas[0];
int min = mas[0];
for (int i = 1; i < mas.Length; i++)
{

    if (mas[i] < min)
    {
        min = mas[i];
    }
    if (mas[i] > max)
    {
        max = mas[i];
    }
}

int count = 0;
Console.WriteLine();
Console.WriteLine("min: " + min);
Console.WriteLine("max: " + max);

for (int i = 0; i < mas.Length; i++)
{

    if ((mas[i] > min) && (mas[i] < max)) count++;
}

Console.WriteLine("count: " + count);
