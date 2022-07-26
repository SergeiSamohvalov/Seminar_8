namespace Homework_8
{
    public class task_58
    // Задайте две матрицы.
    // Напишите программу, которая выведет матрицу произведения
    // элементов двух предыдущих матриц.
    {
        static void Main(string[] args)
        {
            int[,] arrayFirst = new int[4, 4];
            int[,] arraySecond = new int[4, 4];


            FillarrayFirst(arrayFirst);
            PrintArrayFirst(arrayFirst);
            Console.WriteLine();
            FillarraySecond(arraySecond);
            PrintArraySecond(arraySecond);
            Console.WriteLine();
            MultiplicationArray(arrayFirst, arraySecond);



        }

        public static void FillarrayFirst(int[,] arr)

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

        public static void FillarraySecond(int[,] arr)

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

        public static void PrintArrayFirst(int[,] arr)
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

        public static void PrintArraySecond(int[,] arr)
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

        public static void MultiplicationArray(int[,] arrayFirst, int[,] arraySecond)
        {
            var resultMultiplication = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];

            for (int i = 0; i < arrayFirst.GetLength(0); i++)
            {
                for (int j = 0; j < arraySecond.GetLength(1); j++)
                {
                    resultMultiplication[i, j] += arrayFirst[i, j] * arraySecond[i, j];
                    Console.Write($"{resultMultiplication[i, j]} ");
                }
                Console.WriteLine();
            }
            return;
        }
    }
}