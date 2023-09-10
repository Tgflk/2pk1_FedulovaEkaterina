namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c; // инициализация переменных
            Console.Write("Введите число a: "); // выводим текст в консоль
            a = Convert.ToDouble(Console.ReadLine()); // считывает число с клавиатуры
            b = Math.PI / 2; // присваиваем значение переменной b
            Console.Write("Введите число c: "); // выводим текст в консоль
            c = Convert.ToDouble(Console.ReadLine()); // считываем число с клавиатуры
            double firstRes = Math.Sqrt((a * b * c) / 2.4) - ((0.7 * a * b * c) / Math.Sin(b)); // 1-ая часть выражения
            double secondRes = Math.Pow(10, 4) * Math.Pow(Math.Abs(Math.Cos(b)), 1 / 5); // 2-ая часть выражения
            double finalyRes = firstRes + secondRes - ((Math.Abs(b - a)) / 7.5); // 3-ая часть выражения
            Console.WriteLine("Результат равен: " + finalyRes); // выводим результат
        }
    }
}