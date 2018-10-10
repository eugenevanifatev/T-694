using System;

namespace KPIAP5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int errorcode = -461268795;
            Random rand = new Random();
            //№1 В16 Скалярное произведение двух n-мерных векторов
            int scalarMul(int[] v1, int[] v2)
            {
                if (v1.Length != v2.Length) return errorcode;
                int c = 0;
                for (int i = 0; i < v1.Length; i++)
                {
                    c = c + (v1[i] * v2[i]);
                }
                return c;
            }

            int size;
            Console.Write("Размер векторов ");
            try
            {
                size = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException) { size = 0; }
            int[] a = new int[size];
            int[] b = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = rand.Next(0, 20);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                b[i] = rand.Next(0, 20);
                Console.Write(b[i] + " ");
            }

                if (scalarMul(a, b) == errorcode) Console.Write("\nВаши вектора не подходят");
            else Console.Write("\nСкалярное произведение = " + scalarMul(a, b));
            Console.ReadKey();
            Console.Clear();

            //№2 В1 Найти произведение элементов массива, находящихся между минимальным и максимальным элементами
            int maxEl(int[] arr)
            {
                int max = -2147483648;
                for (int i = 0; i < arr.Length; i++)
                {
                    max = Math.Max(max, arr[i]);
                }
                return max;
            }
            int minEl(int[] arr)
            {
                int min = 2147483647;
                for (int i = 0; i < arr.Length; i++)
                {
                    min = Math.Min(min, arr[i]);
                }
                return min;
            }
            int betweenMul(int[] arr)
            {
                if (minEl(arr) == maxEl(arr)) { Console.Write("\nМаксимальный и минимальный элементы массива равны."); return errorcode; }
                if (arr.Length < 3) { Console.Write("\nМассив слишком мал."); return errorcode; }
                int min = minEl(arr);
                int max = maxEl(arr);
                int maxPos = 0, minPos = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == max) { maxPos = i; break; }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == min) { minPos = i; break; }
                }
                if ((Math.Max(maxPos, minPos) - Math.Min(maxPos, minPos)) < 2) { Console.Write("\nМаксимальный и минимальный элементы массива идут друг за другом."); return errorcode; }
                int between = 1;
                for (int i = (Math.Min(maxPos, minPos) + 1); i <= (Math.Max(maxPos, maxPos) - 1); i++)
                {
                    between = between * arr[i];
                }
                return between;
            }
            Console.Write("Размер массива ");
            int size1;
            try
            {
                size1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException) { size1 = 0; }
            int[] d = new int[size1];
            for (int i = 0; i < size1; i++)
            {
                d[i] = rand.Next(1, 10);
                Console.Write(d[i] + " ");
            }
            Console.WriteLine("\nМаксимальный элемент массива: " + maxEl(d));
            Console.WriteLine("Минимальный элемент массива: " + minEl(d));
            if (betweenMul(d) == errorcode) Console.Write("\nВаш массив не подходит.");
            else
            {
                Console.WriteLine("\nПроизведение элементов массива, находящихся между минимальным и максимальным элементами = " + betweenMul(d));
            }
            Console.ReadKey();
        }
    }
}