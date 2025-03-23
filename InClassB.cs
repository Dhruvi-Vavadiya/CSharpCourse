using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    internal class InClassB :InClassA
    {
        public InClassB():base(10) //ctor
        {
            Console.WriteLine("Class B const is called");
        }
        static void Main()
        {
            InClassA objA; //super(parent) ref 

            InClassB inClassB = new InClassB();
           

            objA = inClassB;

            Object obj = new object();
            obj.GetHashCode();
            inClassB.t1();
            inClassB.t2 ();
        }
    }
}
