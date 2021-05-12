using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class multiple_of_3or78
    {
        public void mul_3or7()
        {
            String a = Console.ReadLine();
            int b = Convert.ToInt32(a);

            if (b % 3 == 0 || b % 7 == 0)
            {
                Console.WriteLine(true);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(false);
                Console.ReadKey();
            }
        }
    }
}
