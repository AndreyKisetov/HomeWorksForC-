namespace HomeWorksForCsharp
{
    class Seminar6
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Введите число соответствующее номеру задачи 41 или 43: ");
            {
                int task = Convert.ToInt32(Console.ReadLine());
                if (task == 41)
                {
                    int Task41 = Seminar6.Task41();
                }
                else if (task == 43)
                {
                    double Task43 = Seminar6.Task43();
                }
                else Console.WriteLine("Ну что вы наделали?!"+ NoTask());
            }
        }

        private static int Task41()
        {
            Console.Clear();
            Console.WriteLine($"Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь: \n");
            Console.Write($"Введи любое количество чисел через запятую, затем нажмите Enter: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Кол-во элементов > 0: {count} \n");
            return count;
        }
            
        private static double Task43()
        {
            Console.Clear();
            Console.WriteLine($"Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2: \n");
            Console.Write("Введите b1: ");
            var b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите k1: ");
            var k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b2: ");
            var b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите k2: ");
            var k2 = Convert.ToDouble(Console.ReadLine());

            var x = (b2 - b1) / (k1 - k2);
            var y = k1 * x + b1;

            x = Math.Round(x, 3);
            y = Math.Round(y, 3);
        
            Console.WriteLine($"Пересечение в точке: ({x};{y})");
            return 0;
        }

        private static string NoTask()
        {
            Console.Clear();
            Random r = new Random();
            Console.CursorVisible = false;

            while (true)
            {
                Console.SetCursorPosition(left: r.Next(Console.WindowWidth),
                    top: r.Next(Console.WindowHeight));
                Console.Write(r.Next(2));
                Thread.Sleep(10);
            }
        }
    }
}
