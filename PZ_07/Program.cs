namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            double[,] massive = new double[n, n];
            double sumPlus = 0;
            for (int i = 0; i <= (n - 1); i++)
            {
                for(int j = 0; j <= (n - 1); j++)
                {
                    massive[i, j] = rnd.NextDouble() * 100;
                }
            }
            double min = 101;
            foreach (double elem in massive)
            {
                if (elem < min)
                {
                    min = elem;
                }
            }
            foreach (double elem1 in massive)
            {
                if (elem1 > 0 && elem1 != min)
                {
                    sumPlus += elem1;
                }
            }
            Console.WriteLine($"Произведение минимального элемента матрицы вещественных чисел на сумму положительных элементов: {min * sumPlus}");
        }
    }
}