using System;

namespace Tasks4
{
    class Program
    { 
 
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
