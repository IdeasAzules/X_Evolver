using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Evolvers
{
    public class Print1_100
    {
        public void printNumber()
        {
            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0)
                {
                    Console.Write(" [" + "Fizz" + "] ");
                }
                else
                 if (i % 5 == 0)
                {
                    Console.Write(" [" + "Buzz" + "] ");
                }
                else Console.Write(" [" + i + "] ");
            }


        }
        public void printNumber5()
        {
            Console.WriteLine("\n ");
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.Write(" [" + "FizzBuzz" + "] ");
                }
                else Console.Write(" [" + i + "] ");
            }
        }
        public void printAnyMultiple(int n, string mensaje)
        {
            Console.WriteLine("\n ");
            for (int i = 1; i <= 100; i++)
            {
                if ((i % n == 0) && (i % n == 0))
                {
                    Console.Write(" [" + mensaje + "] ");
                }
                else Console.Write(" [" + i + "] ");
            }
        }
    }
}

