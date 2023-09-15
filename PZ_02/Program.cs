namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double x = 0.0;
            double y = 0.0;
            double z = 0.0;
            if (m > 5) //обработка первого условия первой системы
            {
                x = Math.Sin(m + n);
            }
            else // обработка второго условия первой системы
            {
                x = n + 5 * Math.Sqrt(m * Math.Pow(n, 2) - 2.1 * n);
            }
            if (x <= 0) // обработка первого условия второй системы
            {
                y = Math.Log(m * n + x);
            }
            else // обработка второго условия второй ситемы
            {
                y = Math.Cos(m * x) * Math.Sin(n * x);
            }
            if (Math.Pow(m, 2) + 5 != 0) // проверяем, чтоб делитель не был равен нулю
            {
                z = (2 * x + 3 * y) / (Math.Pow(m, 2) + 5);
            }
            // вывод переменных в консоль
            Console.WriteLine("m = " + m);
            Console.WriteLine("n = " + n);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
        }
    }
}