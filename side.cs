using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class side
    {
        public int s;
        public int side_count()
        {
            Console.WriteLine("enter number of sides");
            string a = Console.ReadLine();
            s = Convert.ToInt32(a);
            return s;
        }

     
    }
}
