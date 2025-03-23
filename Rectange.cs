using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    internal class Rectange : Shape
    {

        public Rectange() : base(5, 2)
        {
            Console.WriteLine("ract ctor");
        }

        public void getArea()
        {
            Console.WriteLine("ract getarea method");
        }
    }

    public class shape_rect_Program
    {
        public static void Main()
        {
            Shape s;
            Rectange r = new Rectange();
            s = r;
            s.getArea();
            r.getArea();


        }
    }

}
