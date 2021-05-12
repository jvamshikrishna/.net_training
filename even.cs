using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class even
    {

        public int length = 20000;
        public void even_num()
        {
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
