//вариант 6 средний уровень
namespace Lab62Fedorov
{
    public class Class1
    {
        public static double[,] InitializeMatrix()
        {
            double[,] matrix = new double[6, 6];

            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = random.NextDouble();
                }
            }
            return matrix;
        }

        public static double FindMinDiagonalElement(double[,] matrix)
        {
            double minDiagonalElement = double.MaxValue;
            for (int i = 0; i < 6; i++)
            {

                if (matrix[i, i] < minDiagonalElement)
                {
                    minDiagonalElement = matrix[i, i];
                }

                if (matrix[i, 5 - i] < minDiagonalElement)
                {
                    minDiagonalElement = matrix[i, 5 - i];
                }
            }
            return minDiagonalElement;
        }

        public static double[] CreateVector(double[,] matrix)
        {
            double[] vector = new double[6];
            for (int i = 0; i < 6; i++)
            {
                double maxElement = double.MinValue;
                for (int j = 0; j < 6; j++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                    }
                }
                vector[i] = maxElement;
            }
            return vector;
        }

        public static double FindProductOfMaxElementAndIndex(double[] vector)
        {
            double maxElement = double.MinValue;
            int maxIndex = -1;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > maxElement)
                {
                    maxElement = vector[i];
                    maxIndex = i;
                }
            }

            return maxElement * maxIndex;
        }
    }
}
