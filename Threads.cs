using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpCourse
{
    internal class Threads
    {

        public static void Main(string[] args)
        {
            Thread mainMethod = Thread.CurrentThread;
            mainMethod.Name = "thread main method ";
            //mainMethod.Start();
            Console.WriteLine(mainMethod.Name);

            countdown();
            countup();

            Threads class_th = new Threads();
            Thread t = new Thread(new ThreadStart(Threads.countup));
            t.Start();

            Console.WriteLine(mainMethod.Name + " is completed!!");

        }

        public static void countdown()
        {
            for (int i = 10; i >=0 ; i--)
            {
                Console.WriteLine("count down func : " + i + "  seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
        public static void countup()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("count up func : " + i + "  seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
