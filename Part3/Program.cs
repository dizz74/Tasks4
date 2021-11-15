using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C:");
            int C = Convert.ToInt32(Console.ReadLine());
            if (A < 1 || B < 1 || C < 1) Console.WriteLine("Ошибка ввода");
            else if(A < C || B < C) Console.WriteLine("Ошибка ввода: сторона квадрата больше, чем прямоугольник, ответ 0");
            else
            {
                int countTotal = 0;
                int tempA= A;

                while (tempA >= C)
                {
                    tempA -= C;
                    int tempB = B;
                    while (tempB >= C)
                    {
                        tempB -= C;
                        countTotal++;
                    }
                }
                Console.WriteLine("Итого в прямоугольнике {0}x{1} помещается {2} квадратов(а) {3}x{3}", A,B,countTotal,C);
            }
            Console.ReadKey();
        }
    }
}
