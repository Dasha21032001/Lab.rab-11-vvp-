using System;

namespace задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число процентов:");
            double P = Convert.ToDouble(Console.ReadLine());//вывод P
            int k = 0;//кол-во месяцев
            double s = 1000;//сумма денег
            while (s <= 1100)
            {
                s= s + s * P / 100;//Увеличиваем прежнюю сумму на число денег, увеличившееся за последний месяц
                k++;
            }
            Console.WriteLine("Кол-во месяцев:" +k +"  "+ "Итоговый размер вклада:" +s);
            Console.ReadLine();
        }
    }
}
