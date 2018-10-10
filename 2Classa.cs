using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*    
   Задание, сделать два класса. В одном классе возвести четные числа до 10, 
   а во втором классе вывести сообщение о том что квадрат числа больше 25
 */


namespace class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Message message = new Message();
            square.Put += message.message;
            square.square();
            Console.ReadKey();
        }
    }
    class Square
    {
        public delegate void OutPut();
        public event OutPut Put;
        double n = 0;
        public void square()
        {
            for (int i = 1; i < 11; i++)
            {
                n = Math.Pow(i, 2);
                Console.WriteLine("Квадрат числа " + i + " = " + n);
                if (n >= 25)
                {
                    Put();
                    Console.ReadKey();
                }
            }
        }

    }
    class Message
    {
        public void message()
        {
            Console.WriteLine("Квадрат числа больше 25!");
        }
    }

}
