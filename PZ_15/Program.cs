using System.IO;
namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вариант 23
            Console.Write("Введите полный путь к каталогу: ");
            string path = Console.ReadLine();
            try
            {
                Random rand = new Random();
                // Получаем список всех текстовых файлов в указанном каталоге
                string[] files = Directory.GetFiles(path, "*.txt");

                // Перебираем файлы
                foreach (string filePath in files)
                {
                    FileInfo fileInfo = new FileInfo(filePath);

                    if (fileInfo.Length < 10 * 1024) // Проверяем, что размер файла меньше 10 Кб
                    {
                        // записываем данные в файл
                        string text = $"TEXT {rand.NextInt64()}";
                        File.WriteAllText(filePath, text);
                    }
                }

                // Выводим обновленный список данных и их размер
                Console.WriteLine("\nОбновленный список данных и их размер:");

                foreach (string filePath in files)
                {
                    FileInfo fileInfo = new FileInfo(filePath);
                    Console.WriteLine($"Файл: {filePath}, Размер: {fileInfo.Length / 1024} Кб");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}