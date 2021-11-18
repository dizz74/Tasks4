using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А:");
            int nA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int nB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C:");
            int nC = Convert.ToInt32(Console.ReadLine());
            if (nA < 1 || nB < 1 || nC < 1) Console.WriteLine("Ошибка ввода");
            else if(nA < nC || nB < nC) Console.WriteLine("Ошибка ввода: сторона квадрата больше, чем прямоугольник, ответ 0");
            else
            {
                int countTotal = 0;
                int tempA= nA;

                while (tempA >= nC)
                {
                    tempA -= nC;
                    int tempB = nB;
                    while (tempB >= nC)
                    {
                        tempB -= nC;
                        countTotal++;
                    }
                }
                Console.WriteLine("Итого в прямоугольнике {0}x{1} помещается {2} квадратов(а) {3}x{3}", nA,nB,countTotal,nC);
            }
            Console.ReadKey();
        }
    }
}
