//cредний уровень вариант 6
using Lab62Fedorov;

double[,] matrix = Class1.InitializeMatrix();
double minDiagonalElement = Class1.FindMinDiagonalElement(matrix);
Console.WriteLine($"Минимальный элемент диагонали: {minDiagonalElement}");

double[] vector = Class1.CreateVector(matrix);
double product = Class1.FindProductOfMaxElementAndIndex(vector);
Console.WriteLine($"Произведение максимального элемента вектора на его индекс: {product}");
