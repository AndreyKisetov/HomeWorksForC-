namespace HomeWorksForCsharp
{
    class Seminar6
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine(
                "Введите число соответствующее номеру задачи 64, 66 или 68 и нажмите Enter: "
            );
            {
                int task = Convert.ToInt32(Console.ReadLine());
                if (task == 64)
                {
                    int Task64 = Seminar6.Task64();
                }
                else if (task == 66)
                {
                    int Task66 = Seminar6.Task66();
                }
                else if (task == 68)
                {
                    int Task68 = Seminar6.Task68();
                }
                else
                    Console.WriteLine("Не некорректное число!");
            }
        }

        public static int Task64()
        {
            Console.Clear();
            Console.WriteLine("Задайте значения M и N. Напишите программу, которая");
            Console.WriteLine("выведет все натуральные числа в промежутке от M до N: \n");

            Console.Write("Введи M: ");
            int M = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введи N: ");
            int N = Convert.ToInt16(Console.ReadLine());

            if (N > M)
                for (int i = M; i <= N; i++)
                {
                    Console.Write($"{i} ");
                }
            else
                for (int i = N; i <= M; i++)
                {
                    Console.Write($"{i} ");
                }
            Console.WriteLine();
            return 0;
        }

        public static int Task66()
        {
            Console.Clear();
            Console.WriteLine("Задайте значения M и N. Напишите программу, которая");
            Console.WriteLine("выведет все натуральные числа в промежутке от M до N: \n");

            Console.Write("Введи M: ");
            int M = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введи N: ");
            int N = Convert.ToInt16(Console.ReadLine());

            int sum = 0;
            if (N > M)
                for (int i = M; i <= N; i++)
                {
                    sum = sum + i;
                }
            else
                for (int i = N; i <= M; i++)
                {
                    sum = sum + i;
                }

            Console.WriteLine(sum);
            Console.WriteLine();
            return 0;
        }

        public static int Task68()
        {
            Console.Clear();
            Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии: \n");
            int m = InputNumbers("Введите m: ");
            int n = InputNumbers("Введите n: ");

            int functionAkkerman = Ack(m, n);

            Console.Write($"Функция Аккермана = {functionAkkerman} ");

            int Ack(int m, int n)
            {
                if (m == 0)
                    return n + 1;
                else if (n == 0)
                    return Ack(m - 1, 1);
                else
                    return Ack(m - 1, Ack(m, n - 1));
            }

            int InputNumbers(string input)
            {
                Console.Write(input);
                int output = Convert.ToInt32(Console.ReadLine());
                return output;
            }

            Console.WriteLine();
            return 0;
        }
    }
}
