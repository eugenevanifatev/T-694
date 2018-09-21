using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double xn = 0.1,xk = 0.5, h = 0.4,x,Yx;
            x = xn;
            do
            {
                Yx = Math.Atan(x);
                x += h;
                Console.Write(Yx+"\n");

            } while (x<=xk+h/2);

            Console.ReadKey();
        }
    }
}

