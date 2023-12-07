using System.IO;
namespace PZ_14

{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"startFile.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            FileStream fileOut = new FileStream(@"fileResult.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileOut);
            while (sr.Peek() >= 0) 
            {
                string line = sr.ReadLine();
                if (line != null && line != "")
                {
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine("Убраны пустые строки и записаны в файл fileResult.txt");
            sr.Close();
            sw.Close();
        }
    }
}