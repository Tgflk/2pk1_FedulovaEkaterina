namespace PZ_12
{
    internal class Program
    {
            static void Main(string[] args)
            {
                // Вариант 25
                Console.Write("Введите длину массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[,] nums = new int[n, n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        nums[i, j] = rnd.Next(-100, 101);
                    }
                }
                Console.WriteLine("Массив:");
                int z = 0;
                foreach (int line in nums)
                {
                    Console.Write(line + " ");
                    z++;
                    if (z % n == 0)
                    {
                        Console.WriteLine();
                        z = 0;
                    }

                }
                Console.WriteLine($"Евклидова норма заданного массива: {Evklid(nums)}");
            }

            static double Evklid(int[,] massive)
            {
                int lenght = Convert.ToInt32(Math.Sqrt(massive.Length));
                double sum = 0.0;
                for (int i = 0; i < lenght; i++)
                {
                    for (int j = 0; j < lenght; j++)
                    {
                        sum += Math.Pow(massive[i, j], 2);
                    }
                }
                return Math.Sqrt(sum);
            }
        }
    }