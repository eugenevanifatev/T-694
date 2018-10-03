using System;

namespace KPIAP4
{
    class Program
    {
        static void Main(string[] args)
        {
            //В 16
            //Подсчитать к - количество цифр в десятичной записи целого неотрицательного числа n
            int digitCount (int number)
            {
                int k = 0;
                if (number == 0) return 1;
                while (number > 0)
                {
                    k++;
                    number /= 10;
                }
                return k;
            }

            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n" + digitCount(n));
            Console.ReadKey();
        }
    }
}
