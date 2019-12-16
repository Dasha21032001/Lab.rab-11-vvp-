using System;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N ( >1 ):");
            int N = Convert.ToInt32(Console.ReadLine());//вывод N
            int K = 1, sum = 1;
            while (sum<N)
            {
                K++;
                sum = sum + K;
            }
            Console.WriteLine("Наименьшее из чисел К:" +K +"  "+ "Сумма равна:" +sum);
            Console.ReadLine();
        }
    }
}
    
