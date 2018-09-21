using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_xx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char c = (char)Console.Read();
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("The character is lowercase.");
                }
                else
                {
                    Console.WriteLine("The character is uppercase.");
                }
            }

            if (Char.IsNumber(c))
                Console.WriteLine("Its a number. ");

            if (Char.IsPunctuation(c))
                Console.WriteLine("Its a punctuation. ");

            if (Char.IsSeparator(c))
                Console.WriteLine("Its a separator. ");

            if (Char.IsWhiteSpace(c))
                Console.WriteLine("Its a separator. ");

            Console.ReadKey();
     
        }
    }
}
