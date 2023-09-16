namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int v = 0;
            while (true) {
                Console.WriteLine("Введите число: ");
                i = Convert.ToInt32(Console.ReadLine());
                if (1 < i && i < 365)
                {
                    v = i % 7;
                    switch (v)
                    {
                        case 0:
                            Console.WriteLine("Понедельник");
                            break;
                        case 1:
                            Console.WriteLine("Вторник");
                            break;
                        case 2:
                            Console.WriteLine("Среда");
                            break;
                        case 3:
                            Console.WriteLine("Четверг");
                            break;
                        case 4:
                            Console.WriteLine("Пятница");
                            break;
                        case 5:
                            Console.WriteLine("Суббота");
                            break;
                        case 6:
                            Console.WriteLine("Воскресенье");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Введите число в диапазоне от 2 до 364");
                }
            }
            
        }
    }
}