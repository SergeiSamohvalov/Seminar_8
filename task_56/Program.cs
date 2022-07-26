namespace Homework_8
{
    public class task_56
    // Задайте прямоугольный двумерный массив.
    // Напишите программу, которая будет находить
    // строку с наименьшей суммой элементов.
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];

            Fillarray(array);
            PrintArray(array);
            Console.WriteLine();
            SearchMinSum(array);

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

        public static void SearchMinSum(int[,] array)
        {
            int minRowSum = int.MaxValue, indexMinRow = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                    rowSum += array[i, j];

                if (rowSum < minRowSum)
                {
                    minRowSum = rowSum;
                    indexMinRow = i;
                }
            }

            Console.WriteLine($"Индекс строки с наименьшей суммой элементов -> {indexMinRow}");
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[indexMinRow, j] + "\t");



        }

    }


}


