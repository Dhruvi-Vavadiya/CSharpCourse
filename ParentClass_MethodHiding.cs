using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    public class ParentClass_MethodHiding
    {

        public virtual void Test1_virtual()
        {
            Console.WriteLine("ParentClass_MethodHiding test 1 meth with [virtual]");
        }
        public void Test2_without_virtual()
        {
            Console.WriteLine("ParentClass_MethodHiding test 2 meth without virtual");
        }
    }

    public class ChildClass_MethodHiding : ParentClass_MethodHiding
    {
        public override void Test1_virtual() //method overriding
        {
            Console.WriteLine("ChildClass_MethodHiding test 1 meth with [virtual]");
        }
        public new void Test2_without_virtual() // method hiding
        {
            Console.WriteLine("ChildClass_MethodHiding test 2 meth without virtual");
        }
        static void Main()
        {
            ChildClass_MethodHiding c =  new ChildClass_MethodHiding();

            c.Test1_virtual();
            c.Test2_without_virtual();

           
        }
    }
}
