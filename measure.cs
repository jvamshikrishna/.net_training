using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class measure
    {
        public int height;
        public int basee;
        public int base_value()
        {
            Console.WriteLine("enter base value");
            string b = Console.ReadLine();
            basee = Convert.ToInt32(b);
            return basee;
        }
        public int height_value()
        {
            Console.WriteLine("enter height value");
            string h = Console.ReadLine();
            height = Convert.ToInt32(h);
            return height;
        }


    }
}
