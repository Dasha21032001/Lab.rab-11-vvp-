using System;

namespace задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число А:");
            int A = Convert.ToInt32(Console.ReadLine());//вывод А
            Console.WriteLine("Введите целое положительное число В:");
            int B = Convert.ToInt32(Console.ReadLine());//вывод В
            if (A>0 && B>0)
            {
                while (A != 0 && B != 0)
                {
                    if (A > B)

                    {
                        A = A % B;
                    }
                    else
                    {
                        B = B % A;
                    }
                }
                Console.WriteLine("Наибольший общий делитель:" + (A + B));
            }
            else { Console.WriteLine("Ошибка"); }
            Console.ReadLine();
        }
    }
}
