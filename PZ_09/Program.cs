using System.IO;

namespace PZ_09
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите путь к файлу на диске:");
            string filePath = Console.ReadLine();

            // Проверяем корректность пути
            if (!filePath.StartsWith("D:\\") && !filePath.StartsWith("C:\\"))
            {
                Console.WriteLine("Некорректный путь. Путь должен начинаться с D:\\ или C:\\");
                return;
            }

            // Разделяем путь на каталоги
            string[] directories = filePath.Split('\\');

            // Выводим названия каталогов
            Console.WriteLine("Названия каталогов в пути:");
            for (int i = 0; i < directories.Length - 1; i++) // Игнорируем имя файла, поэтому длина массива минус 1
            {
                Console.WriteLine(directories[i]);
            }
        }
    }
}