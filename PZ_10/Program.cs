namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = 0;
            char letter = ' ';

            for (char c = 'a'; c < 'z'; c++)
            {
                int tmp = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == c)
                        tmp++;
                }
                if (tmp > count)
                {
                    count = tmp;
                    letter = c;
                }
            }

            Console.WriteLine(letter + " Встречается " + count + " раз(-а)");
            Console.ReadKey();
        }
    }
}