namespace HomeWorksForCsharp
{
    class Seminar6
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Введите число соответствующее номеру задачи 54, 56 или 58 и нажмите Enter: ");
            {
                int task = Convert.ToInt32(Console.ReadLine());
                if (task == 54)
                {
                    int Task54 = Seminar6.Task54();
                }
                else if (task == 56)
                {
                    int Task56 = Seminar6.Task56();
                }
                else if (task == 58)
                {
                    int Task58 = Seminar6.Task58();
                }
                else
                    Console.WriteLine("Не некорректное число!");
            }
        }

        public static int Task54()
        {
            Console.Clear();
            Console.WriteLine("\t\tЗадайте двумерный массив. Напишите программу,");
            Console.WriteLine("которая упорядочит по возрастанию элементы каждой строки двумерного массива: \n");

            int m = 3;
            int n = 4;
            int[,] array = new int[m, n];

            CreateArray(array);
            WriteArray(array);

            Console.WriteLine($"\nОтсортированный массив: \n");
            SortElementsRowArray(array);
            WriteArray(array);

            void SortElementsRowArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1) - 1; k++)
                        {
                            if (array[i, k] > array[i, k + 1])
                            {
                                int number = array[i, k + 1];
                                array[i, k + 1] = array[i, k];
                                array[i, k] = number;
                            }
                        }
                    }
                }
            }

            void CreateArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(0,10);
                    }
                }
            }

            void WriteArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            return 0;
        }

        public static int Task56()
        {
            Console.Clear();
            Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу,");
            Console.WriteLine("которая будет находить строку с наименьшей суммой элементов: \n");

            Random random = new Random();
            int[,] arr = new int[random.Next(2, 6), random.Next(2, 6)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1, 10);
                    Console.Write(arr[i, j] + "  ");
                    sum += arr[i, j];
                }
                Console.WriteLine(" Сумма элементов в строке: "+ sum);
            }
            Console.WriteLine("_____________________");
            Console.Write("Строка с наименьшей суммой элементов:");

            int minSumElementRow = int.MaxValue;
            int index = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
                while (sum < minSumElementRow)
                {
                    index = i;
                    minSumElementRow = sum;
                }
            }
            Console.WriteLine(index+1 +"\n");
            return 0;
        }

        public static int Task58()
        {
            Console.Clear();
            Console.WriteLine("\tЗадайте две матрицы. Напишите программу, которая");
            Console.WriteLine("выведет матрицу произведения элементов двух предыдущих матриц: \n");

            int m = 3;
            int n = 4;

            int[,] firstMartrix = new int[m, n];
            CreateArray(firstMartrix);
            Console.WriteLine($"\nПервая матрица:");
            WriteArray(firstMartrix);

            int[,] secomdMartrix = new int[m, n];
            CreateArray(secomdMartrix);
            Console.WriteLine($"\nВторая матрица:");
            WriteArray(secomdMartrix);

            int[,] resultMatrix = new int[m, n];

            MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
            Console.WriteLine($"\nПроизведение элементов первой и второй матриц:");
            WriteArray(resultMatrix);

            void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
            {
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    {
                        int mul = 0;
                        for (int k = 0; k < firstMartrix.GetLength(1); k++)
                        {
                            mul = firstMartrix[i, j] * secomdMartrix[i, j];
                        }
                        resultMatrix[i, j] = mul;
                    }
                }
            }
            Console.WriteLine();

            void CreateArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(0,9);
                    }
                }
            }

            void WriteArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            return 0;
        }
    }
}
