namespace PZ_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вариант 25
            // Задача 1
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = -8;
            int d = -3;
            int first_res = getProgress(a, d, n);
            Console.WriteLine($"{n} член арифметической прогрессии: {first_res}");
            // Задача 2
            Console.Write("Введите n2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            double d1 = 4.0;
            double q = -0.01;
            double second_res = geomProgress(d1, q, n2);
            Console.WriteLine($"{n2} член геометрической прогрессии: {second_res}");
            // Задача 3
            Console.Write("A: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Все числа в промежутке: ");
            int third = getAllNums(a2, b);
            Console.WriteLine();
            // Задача №4(4)
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Reverse: ");
            Reverse(number);
        }

        public static int getProgress(int first, int step, int n)
        {
            int result;
            if (n == 1)
            {
                return first;
            }
            result = getProgress(first + step, step, n - 1);
            return result;
        }

        public static double geomProgress(double d, double q, int n2)
        {
            double res;
            if (n2 == 1)
            {
                return 1;
            }
            else if (n2 == 2)
            {
                res = d * q;
            }
            else
            {
                res = q * geomProgress(d, q, n2 - 1);
            }
            return res;
        }

        public static int getAllNums(int a, int b)
        {
            Console.Write(a + " ");
            if (a == b)
            {
                return 0;
            }
            else if (a > b)
            {
                return getAllNums(a - 1, b);
            }
            return getAllNums(a + 1, b);
        }

        public static int Reverse(int num)
        {
            int c = num % 10;
            Console.Write(c);
            num = num / 10;
            if (num > 0)
            {
                Reverse(num);
            }
            return 0;
        }
    }
}