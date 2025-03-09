using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    internal class Program
    {
        public delegate void AddDelegate(int x, int y);
        public delegate string sayDelegate(string s);
        public void AddNum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string sayHello(string s)
        {
            return "hello";
        }
        static void Main(string[] args)
        {


            Program p = new Program();
            AddDelegate ads = new AddDelegate(p.AddNum);
            ads(5, 1);
            ads.Invoke(85, 5);

            sayDelegate say = new sayDelegate(sayHello);

            string sayhellodel = say("welcome");
            string dfcd = say.Invoke("dfd");
            Console.WriteLine(sayhellodel);

            p.AddNum(1, 2);
            string str = Program.sayHello("hello");
            Console.WriteLine(str);
        }
    }
}
