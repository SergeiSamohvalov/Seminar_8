namespace Homework_8
{
    public class task_54

    // Задайте двумерный массив. Напишите программу, которая упорядочит по
    // возрастанию элементы каждой строки двумерного массива.

    {
        static void Main(string[] args)
        {
            int rows = 4;
            int columns = 4;
            int[,] array = new int[rows, columns];
           
            Fillarray(array);
            PrintArray(array);
            Console.WriteLine();
            Sorting(array);
            PrintArray(array);
        }
        public static void Fillarray(int[,] arr)

        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 10);
                }
            }
            return;
        }

        public static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void Sorting(int[,] arr)
        {
            int a = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = j + 1; k < arr.GetLength(1); ++k)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            a = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = a;
                        }

                    }

                }
            }

        }
    }
}


