using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naresh_i_Technologies_Delegate
{
    internal class ConstructorsDemo
    {
        static int s;
        int p;
        //static const are call automatically  implicitly
        static ConstructorsDemo()
        {
            Console.WriteLine("static const are called");
        }

        //explicitly
        public ConstructorsDemo(int x)
        {
            this.p = x;
            Console.WriteLine("public const :- " + (x*x));
        }

        static void Main()
        {
            Console.WriteLine("main method is called");

            ConstructorsDemo c1 = new ConstructorsDemo(5); // c1 is instance of class
            ConstructorsDemo r1 = c1; //r1 is refrece of class
            ConstructorsDemo c2 = new ConstructorsDemo(8);

            Console.WriteLine("satic variable :- " + s);
            Console.WriteLine(c1.p + " " + c2.p);
            Console.ReadLine();
        }
    }
}
