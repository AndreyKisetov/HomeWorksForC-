namespace HomeWorksForCsharp
{
    class Seminar4
    {
        public static void Main()
        {
            Console.WriteLine("Введите число соответствующее номеру задачи 34 или 36 или 38: ");
            {
                int task = Convert.ToInt32(Console.ReadLine());
                if (task == 34)
                {
                    string Task34 = Seminar4.Task34();
                }
                else if (task == 36)
                {
                    string Task36 = Seminar4.Task36();
                }
                else if (task == 38)
                {
                    string Task38 = Seminar4.Task38();
                }
                else Console.WriteLine("Введено некорректное число!");
            }
        }

        private static string Task34()
        {
            Console.Clear();
            Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве:\n");
            int[] numbers = new int[4];
            void WriteArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(100, 1000);
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            int QuantityPositive(int[] array)
            {
                int quantity = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        quantity++;
                    }
                }
                return quantity;
            }
            WriteArray(numbers);
            string quantity = Convert.ToString(QuantityPositive(numbers));
            Console.WriteLine($"Количество чётных чисел в массиве: {quantity}\n");
            return quantity;
        }
        private static string Task36()
        {
            Console.Clear();
            Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях:\n");
            int[] array = new int[4];
            int sumElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 10);
                Console.Write(array[i] + " ");
                if (i % 2 != 0)
                {
                    sumElements = sumElements + array[i];
                }
            }
            Console.WriteLine();
            string arr = Convert.ToString(sumElements);
            Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumElements}\n");
            return arr;
        }
        public static string Task38()
        {
            Console.Clear();
            Console.WriteLine($"Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива:\n");
            double[] array = new double[4];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().NextDouble() * 10;
                Console.Write("{0,5:F2}", array[i]);
            }
            double maxNumber = array[0];
            double minNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxNumber < array[i])
                {
                    maxNumber = array[i];
                }
                if (minNumber > array[i])
                {
                    minNumber = array[i];
                }
            }
            double difference = maxNumber - minNumber;
            string arr = Convert.ToString(difference);
            Console.WriteLine($"\nразница между между максимальным ({maxNumber:F2}) и минимальным ({minNumber:F2}) элементами массива: {difference:F1}\n");
            return arr;
        }
    }
}
