using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class prime : even
    {
        public void prime_num()
        {
            for (int i = 2; i <= length; i++)
            {
                int c = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                    
                }
                
                if (c == 2)
                {
                    Console.WriteLine(i + " is prime number");

                }
            }

        }
    }
}
