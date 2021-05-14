  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Person1
    {
        //properties
        public string name;
        public int age;


        // this constructor willbe initiated when object ios initiated
        public Person1( int age, string name)
        {
            this.age = age;
            this.name = name;

            Console.WriteLine(age);
            Console.ReadKey();


        }
      
    }

}
