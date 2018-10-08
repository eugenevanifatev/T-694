using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int razmer;
            int vbor;
        pzc:
            try
            {
                Console.Write("введите размер пароля: ");
                razmer = System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("выбирите тип пароля: ");
                Console.WriteLine("1-только цифры");
                Console.WriteLine("2-цифры и буквы нижнего регистра");
                Console.WriteLine("3-цифры и буквы верхнего регистра");
                Console.WriteLine("4-цифры, буквы нижнего регистра и буквы верхнего регистра");
                Console.WriteLine("5-буквы нижнего регистра и буквы верхнего регистра");
                Console.WriteLine("6-только буквы нижнего регистра");
                Console.WriteLine("7-только буквы верхнего регистра");
                vbor = System.Convert.ToInt32(Console.ReadLine());
            } catch (Exception) { Console.WriteLine("Ошибко"); goto pzc; }
            Random a = new Random();
            switch (vbor)
            {
                case 1:
                    for(int i=0;i<razmer;i++)
                    {
                        Console.Write(a.Next(1,10));
                    }
                    break;
                case 2:
                    for (int i = 0; i < razmer; i++)
                    {
                        if(a.Next(0,2)==1)
                        {
                            Console.Write(a.Next(1, 10));
                        }
                        else
                        {
                            Console.Write((char) a.Next(97, 122));
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < razmer; i++)
                    {
                        if (a.Next(0, 2) == 1)
                        {
                            Console.Write(a.Next(1, 10));
                        }
                        else
                        {
                            Console.Write((char)a.Next(65, 90));
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < razmer; i++)
                    {
                        if (a.Next(0, 3) == 1)
                        {
                            Console.Write(a.Next(1, 10));
                        }
                        else if (a.Next(0, 3) == 2)
                        {
                            Console.Write((char)a.Next(97, 122));
                        }
                        else
                        {
                            Console.Write((char)a.Next(65, 90));
                        }
                    }
                    break;
                case 5:
                    for (int i = 0; i < razmer; i++)
                    {
                        if (a.Next(0, 2) == 1)
                        {
                            Console.Write((char)a.Next(97, 122));
                        }
                        else
                        {
                            Console.Write((char)a.Next(65, 90));
                        }
                    }
                    break;
                case 6:
                    Console.Write((char)a.Next(97, 122));
                    break;
                case 7:
                    Console.Write((char)a.Next(65, 90));
                    break;
            }
            Console.ReadKey();
        }
    }
}
