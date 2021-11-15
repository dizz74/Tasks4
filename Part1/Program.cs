using System;

namespace Tasks4
{
    class Program
    { 
        /*
         Обязательная задача*. 
        Ввести целое число N > 0. 
        Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1). 
        После добавления к сумме каждого слагаемого выводить текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:");
            int numN = Convert.ToInt32(Console.ReadLine());
            if (numN < 1) Console.WriteLine("необходимо число > 0");
            else
            {
                int qw = 0;
                for (int i = 1; i <= numN; i++)
                {
                    qw += 2 * i - 1;
                    Console.WriteLine("{0}^2={1}", i, qw);
                }
            }
            Console.ReadKey();
        }
    }
}
