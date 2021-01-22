using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            do
            {
                m = Convert.ToInt32(Math.Pow(m, 2));
                Console.WriteLine(m);
            }
            while (m > n);
        }

    }
}
