using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    internal class InClassB :InClassA
    {
        public InClassB():base(10)
        {
            Console.WriteLine("Class B const is called");
        }
        static void Main()
        {
            InClassB inClassB = new InClassB();
            InClassA inClassA;

            inClassA = inClassB;

            Object obj = new object();
            obj.GetHashCode();
            inClassB.t1();
            inClassB.t2 ();
        }
    }
}
