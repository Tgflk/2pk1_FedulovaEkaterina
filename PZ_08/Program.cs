using System;

namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Random random = new Random();

                // Создание ступенчатого массива
                int[][] array = new int[10][];

                // Заполнение массива рандомными значениями
                for (int i = 0; i < array.Length; i++)
                {
                    // Генерация случайной длины второго измерения
                    int length = random.Next(3, 16);

                    array[i] = new int[length];
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] = random.Next(1, 101);
                    }
                }

                // Вывод массива на консоль
                Console.WriteLine("\nСтупенчатый массив");
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write(array[i][j] + " ");
                    }
                    Console.WriteLine();
                }

                // Создание нового одномерного массива с последними элементами каждой строки
                
                int[] lastElements = new int[array.Length];

                for (int k = 0; k < array.Length; k++)
                {
                    int lastIndex = array[k].Length - 1;
                    lastElements[k] = array[k][lastIndex];
                }

                // Вывод массива последних элементов на консоль
                Console.WriteLine("\nМассив последних элементов");
                for (int k = 0; k < lastElements.Length; k++)
                {
                    Console.Write(lastElements[k] + " ");
                }
                
                // Массив с максимальными элементами каждого подмассива
                int[] maxElements = new int[array.Length];

                for (int v = 0; v < array.Length; v++)
                {
                    int maxElement = array[v][0]; // Предполагаем, что первый элемент строки является максимальным
                    for (int j = 1; j < array[v].Length; j++)
                    {
                        if (array[v][j] > maxElement)
                        {
                            maxElement = array[v][j];
                        }
                    }
                    maxElements[v] = maxElement;
                }

                // Вывод массива максимальных элементов на консоль
                Console.WriteLine("\nМассив максимальных элементов");
                for (int k = 0; k < maxElements.Length; k++)
                {
                    Console.Write(maxElements[k] + " ");
                }
                
                // Меняем местами 1 элемент с максимальным
                for (int t = 0; t < array.Length; t++)
                {
                    int maxElementIndex = 0; // Индекс максимального элемента
                    int maxElement = array[t][0]; // Предполагаем, что первый элемент строки является максимальным

                    for (int r = 1; r < array[t].Length; r++)
                    {
                        if (array[t][r] > maxElement)
                        {
                            maxElement = array[t][r];
                            maxElementIndex = r;
                        }
                    }

                    // Замена первого элемента и максимального элемента в строке
                    int temp = array[t][0];
                    array[t][0] = maxElement;
                    array[t][maxElementIndex] = temp;
                }

                // Вывод обновленного массива на консоль
                Console.WriteLine("\nОбнавленный массив");
                for (int t = 0; t < array.Length; t++)
                {
                    for (int r = 0; r < array[t].Length; r++)
                    {
                        Console.Write(array[t][r] + " ");
                    }
                    Console.WriteLine();
                }
                // Реверс каждой строки ступенчатого массива
                for (int i = 0; i < array.Length; i++)
                {
                    Array.Reverse(array[i]);
                }

                // Вывод обновленного массива на консоль
                Console.WriteLine("\nОбнавленный массив (реверс)");
                for (int z = 0; z < array.Length; z++)
                {
                    for (int l = 0; l < array[z].Length; l++)
                    {
                        Console.Write(array[z][l] + " ");
                    }
                    Console.WriteLine();
                }
                // Среднее значение для каждой строчки
                for (int x = 0; x < array.Length; x++)
                {
                    int sum = 0;
                    for (int n = 0; n < array[x].Length; n++)
                    {
                        sum += array[x][n];
                    }
                    int average = sum / array[x].Length;
                    Console.WriteLine("\nСреднее значение в строке {0}: {1}", x, average);
                }
            }
        }
    }
}