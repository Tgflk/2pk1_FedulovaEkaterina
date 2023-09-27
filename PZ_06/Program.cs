namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] massive = new int[20];
            for (int i = -15; i <= 14; i++)
            {
                massive[count] = i;               
            }
            Array.Sort(massive);
            int maxNum = massive[0];
            int maxAbsCount = 0;
            for(int i1 = 0; i1 < 20; i1++)
            {
                if (Math.Abs(massive[i1]) > maxNum)
                {
                    maxAbsCount += 1;
                }
            }
            Console.WriteLine($"Количество элементов по модулю больших, чем максимальный: {maxAbsCount}");


        }
    }
}