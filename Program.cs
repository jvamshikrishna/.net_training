using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle t = new Triangle();
            t.height_value();
            t.base_value();
            int x = t.calc();
            Console.WriteLine("area: " + x);
            Console.ReadLine();

            measure m = new measure();
            int y = m.height_value() * m.base_value();
            Console.WriteLine("area: " + y);
            Console.ReadLine();

        }
    }
}
