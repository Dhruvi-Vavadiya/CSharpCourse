using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    internal class MethodOverloadding
    {
        public void Test()
        {
            Console.WriteLine("Test method 1");
        }
        public string Test(double j) => "Test method 1 but string retunr type ::" + j + 1;
        public void Test(int i)
        {
            Console.WriteLine("Test method 2 :: " + i);
        }
        public void Test(string s)
        {
            Console.WriteLine("Test method 3 ::" + s);
        }
        public void Test(int i, string s)
        {
            Console.WriteLine("Test method 4 :: " + i + " :: " + s);
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("Test method 5 :: " + s + " :: " + i);
        }

        static void Main(string[] args)
        {
            MethodOverloadding method = new MethodOverloadding();
            //method.Test("sduri",9);
            method.Test();

            string iss = method.Test(2.56);
            Console.WriteLine(iss);

            int i;
            string s = "Hello World";
            i = s.IndexOf('W');
            i += s.IndexOf("llo");
            i += s.IndexOf('g', 5);

            Console.WriteLine(i);
        }
    }
}
