namespace HomeWorksForCsharp
{
    class Seminar4
    {
        public static void Main()
        {
            Console.WriteLine("Введите число соответствующее номеру задачи 25 или 27 или 29: ");
            {
                int task = Convert.ToInt32(Console.ReadLine());
                if (task == 25)
                {
                    string Task25 = Seminar4.Task25();
                }
                else if (task == 27)
                {
                    string Task27 = Seminar4.Task27();
                }
                else if (task == 29)
                {
                    string Task29 = Seminar4.Task29();
                }
                else Console.WriteLine("Введено некорректное число!");
            }
        }

        static string Task29()
        {
            Console.WriteLine("Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) элементов (значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.");
            Random r = new Random();
            int size = new Random().Next(5, 11);
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = r.Next(0, 41);
                Console.Write(array[i] * array[i] + " ");
            }
            Console.WriteLine();
            string? arr = Convert.ToString(array);
            return arr;
        }

        private static string Task27()
        {
            Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int SumNumber(int number)
            {
                int count = Convert.ToString(number).Length;
                int advance = 0;
                int result = 0;
                for (int i = 0; i < count; i++)
                {
                    advance = number - number % 10;
                    result = result + (number - advance);
                    number = number / 10;
                }
                return result;
            }
            int sumNumber = SumNumber(number);
            Console.WriteLine(sumNumber);
            string sum = Convert.ToString(sumNumber);
            return sum;
        }

        private static string Task25()
        {
            Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
            Console.WriteLine("Введите числа A и B: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int number = A;
            for (int i = 1; i < B; i++)
            {
                A = A * number;
            }
            Console.WriteLine(A);
            string a = Convert.ToString(A);
            return a;
        }
    }
}
