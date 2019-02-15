using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace origin_eulers_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumTotal = 0;
            int i = 0;

            while (i < 1000)
            {
                if (i %3==0  || i %5==0 )
                {
                    sumTotal+=i;
                }
                i++;                
            }
            Console.WriteLine(sumTotal);

        }
    }
}
