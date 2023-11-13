//задание 23 выскоий уровень
int[,] mas = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i == 2 || j == 2) mas[i, j] = 1;
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}