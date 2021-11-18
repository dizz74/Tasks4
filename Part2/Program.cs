using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            int positiveCount = 0, negativeCount = 0;

            int input;
            do
            {
                Console.WriteLine("Введите число:");
                input = Convert.ToInt32(Console.ReadLine());


                if (input != 0)
                {
                    if (input > 0) positiveCount++;
                    else negativeCount++;

                    if (positiveCount == negativeCount) 
                        Console.WriteLine("Одинаковое количество положительных и отрицательных");
                    else
                        Console.WriteLine("Положительных чисел " + ((positiveCount > negativeCount) ? "больше" : "меньше") + ",чем отрицательных");
                }
            }
            while (input != 0);
            Console.WriteLine("Вы ввели ноль, выход");
            Console.ReadKey();
        }

    }
}
