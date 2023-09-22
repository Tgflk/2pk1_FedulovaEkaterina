namespace Pz_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите начальную температуру в градусах Цельсия:");
                double startCelsius = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите конечную температуру в градусах Цельсия:");
                double endCelsius = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите шаг изменения температуры в градусах Цельсия:");
                double step = double.Parse(Console.ReadLine());

                Console.WriteLine("Температура (°C)\tТемпература (°F)");

                for (double celsius = startCelsius; celsius <= endCelsius; celsius += step)
                {
                    double fahrenheit = (9.0 / 5.0) * celsius + 32;
                    Console.WriteLine($"{celsius}\t\t{fahrenheit}");
                }
            }
    }
}