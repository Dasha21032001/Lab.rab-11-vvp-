using System;

namespace Лаб.раб__11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А:");
            int A = Convert.ToInt32(Console.ReadLine());//вывод А
            Console.WriteLine("Введите число В:");
            int B = Convert.ToInt32(Console.ReadLine());//вывод В
            if (A < B)
            {
                for (int i = 1; i <= A; i++)
                {
                    Console.WriteLine("Вывод A:" +A);
                }

                for (int i = 1; i <= B; i++)
                {
                    Console.WriteLine("Вывод В:" + B);
                }
            }
            else { Console.WriteLine("Ошибка"); }
            Console.ReadLine();
        }
    }
}
