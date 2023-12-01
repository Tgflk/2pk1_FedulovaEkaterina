namespace PZ_11
{
    internal class Program
    {
        
    static void PowerA234(double A, out double B, out double C, out double D)
        {
            B = A * A;
            C = B * A;
            D = C * A;
        }

        static void Main()
        {
            double num1 = 2.5;
            double num2 = 3.7;
            double num3 = 4.2;
            double num4 = 1.8;
            double num5 = 6.9;

            double pow2, pow3, pow4;

            PowerA234(num1, out pow2, out pow3, out pow4);
            Console.WriteLine($"{num1} во второй степени: {pow2}, в третьей степени: {pow3}, в четвертой степени: {pow4}");

            PowerA234(num2, out pow2, out pow3, out pow4);
            Console.WriteLine($"{num2} во второй степени: {pow2}, в третьей степени: {pow3}, в четвертой степени: {pow4}");

            PowerA234(num3, out pow2, out pow3, out pow4);
            Console.WriteLine($"{num3} во второй степени: {pow2}, в третьей степени: {pow3}, в четвертой степени: {pow4}");

            PowerA234(num4, out pow2, out pow3, out pow4);
            Console.WriteLine($"{num4} во второй степени: {pow2}, в третьей степени: {pow3}, в четвертой степени: {pow4}");

            PowerA234(num5, out pow2, out pow3, out pow4);
            Console.WriteLine($"{num5} во второй степени: {pow2}, в третьей степени: {pow3}, в четвертой степени: {pow4}");
        }
    }
}