using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naresh_i_Technologies_Delegate
{
    ////function delegate
    //public delegate double del_addnum1(int x, float y, double z);

    ////action delegate
    //public delegate void del_addnum2(int x, float y, double z);

    ////predicate delegate
    //public delegate bool del_checklength(string str);
    internal class GenericDelegate
    {
        public static double addNum1(int x,float y, double z)
        {
            return x + y + z;
        }
        public static void addNum2(int x, float y, double z)
        {
            Console.WriteLine( x + y + z);
        }
        public static bool checklength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }

        //generic delegate
        //1.func
        //2.acion
        //3.predicate
        static void Main()
        {
            //function del(input delegate)
            Func<int,float,double,double> obj1 = (x,y,z) =>
            {
                return x + y + z;
            };
            double result_obj1 = obj1.Invoke(100, 2.5f, 55.525);
            Console.WriteLine(result_obj1);

            //action (output delegate) only void return type can be anything up till 16
            Action<int,float,double> obj2 = addNum2;
            obj2.Invoke(100, 2.5f, 55.525);

            //predicate only bool value
            //Predicate<string> obj3 = checklength;
            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };

            //Func<string,bool> obj3 = checklength;
            bool result_obj3 = obj3.Invoke("dev");
            Console.WriteLine(result_obj3);
        }

    }
}
