namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            for (int i = 10; i <= 50; i += 6)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Задание №2");
            char myChar = 'м';
            int n = 6;
            for (int x = 1; x <= n; x++)
            {
                Console.Write(myChar);
                myChar++;
            }

            Console.WriteLine("\nЗадание №3");
            int n1 = 8;
            int m = 10;
            for (int j = 0; j < m; j++)
            {
                for (int j1 = 0; j1 < n1; j1++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Задание №4");
            int count = 0;
            for(int i1 = -50; i1 <= 50; i1++)
            {
                if (i1 % 20 == 0)
                {
                    count++;
                    Console.Write($"{i1} ");
                }
            }
            Console.WriteLine($"\nКоличество чисел, кратных 20: {count}");

            Console.WriteLine("Задание №5");
            for(int i2 = 0, j2 = 40; j2 - i2 > 10;)
            {
                Console.WriteLine($"i = {i2}\tj = {j2}");
                j2--;
                i2++;

            }
        }
    }
}