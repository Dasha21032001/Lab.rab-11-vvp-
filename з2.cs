using System;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину А:");
            int A = Convert.ToInt32(Console.ReadLine());//вывод А
            Console.WriteLine("Введите длину В:");
            int B = Convert.ToInt32(Console.ReadLine());//вывод В
            if (A > B)
            {
                while (A >= B)
                {
                    A -= B;
                }
                Console.WriteLine("Вывод незанятой части А:" + A);
            }
            else
            { Console.WriteLine("Ошибка"); }
            Console.ReadLine();
        }
    }
}
