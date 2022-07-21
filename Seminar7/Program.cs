namespace HomeWorksForCsharp
{
    class Seminar6
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Введите число соответствующее номеру задачи 47, 50 или 52 и нажмите Enter: ");
            {
                int task = Convert.ToInt32(Console.ReadLine());
                if (task == 47)
                {
                    double Task47 = Seminar6.Task47();
                }
                else if (task == 50)
                {
                    double Task50 = Seminar6.Task50();
                }
                else if (task == 52)
                {
                    double Task52 = Seminar6.Task52();
                }
                else
                    Console.WriteLine("Не некорректное число!");
            }
        }

        public static double Task47()
        {
            Console.Clear();
            Console.WriteLine("Задайте двумерный массив размером m*n, заполненный случайными вещественными числами: \n");

            int m = 3;
            int n = 4;
            double[,] array = new double[m, n];

            FillArray(array);

            return 0;
        }

        public static void FillArray(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(-99, 100);
                    Console.Write("{0,5:R1} ", arr[i, j] / 10);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return;
        }

        public static double Task50()
        {
            Console.Clear();
            Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, ");
            Console.WriteLine("и возвращает значение этого элемента или же указание, что такого элемента нет: \n");

            Console.Write("Введите строку:");
            int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Введите столбец:");
            int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
            int n = 5;
            int m = 7;
            Random random = new Random();
            int[,] arr = new int[n, m];
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(10, 100);
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
            {
                Console.WriteLine("Такого элемента нет");
            }
            else
            {
                Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
            }
            Console.ReadLine();
            return 0;
        }

        public static double Task52()
        {
            Console.Clear();
            Console.WriteLine($"Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце: \n");

            Random random = new Random();
            int[,] arr = new int[random.Next(2, 6), 5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1, 10);
                    Console.Write(arr[i, j] + "    ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("_____________________");
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine("среднее арифметическое элементов в каждом столбце:");
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    sum += arr[i, j];
                }
                Console.Write("{0,4:F2} ", sum / arr.GetLength(0));
            }
            Console.ReadLine();
            return 0;
        }
    }
}
