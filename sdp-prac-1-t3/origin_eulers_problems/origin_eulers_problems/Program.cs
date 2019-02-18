using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace origin_eulers_problems
{
    class Program
    {
        static long MaxFactor(long num)
        {
            long k = 2;
            while (k * k <= num)
            {
                if (num % k == 0)
                {
                    num /= k;
                }
                else
                {
                    ++k;
                }
            }

            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{MaxFactor(600851475143)} is the largest prime number of 600851475143");
            Console.ReadLine();
        }
    }
}
