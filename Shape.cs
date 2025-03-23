using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    public class Shape
    {
        int n1, n2;

        public Shape(int a,int b)
        {
            this.n1 = a; 
            this.n2 = b;
        }
        public void getArea()
        {
            Console.WriteLine("shape class getarea method :: " + n1 + " ::" + n2);
        }
    }
}
