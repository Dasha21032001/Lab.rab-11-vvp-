using System;

namespace задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число N (  >1  ):");
            int N = Convert.ToInt32(Console.ReadLine());//вывод N
            int F1 = 1;//первый член ряда Фибоначчи
            int F2 = 1;//второй член ряда Фибоначчи
            int k = 2;
                while (N > F2)
                {
                    F2 = F1 + F2;
                    F1 = F2 - F1;
                    k++;
                }
                if (N == F2)
                {
                     Console.WriteLine("Порядковый номер числа Фибоначчи:" +k);
                }
                else { Console.WriteLine("N не явл-ся числом Фибоначчи"); }
            Console.ReadLine();
        }
    }
}
