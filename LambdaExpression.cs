using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naresh_i_Technologies_Delegate
{
    internal class LambdaExpression
    {
        //public static string Geet(string name)
        //{
        //    return "Hello " + name + " geetmethod lambaexpression";
        //}

        static void Main()
        {
            //anonymous method
            grettingDel gretting = delegate (string name)
            {
                return "gm  " + name + " geetmethod anonymous";
            };
            string str =gretting.Invoke("raju");
            Console.WriteLine(str);

            grettingDel obj = (name) =>
            {
                return "Hello " + name + " geetmethod lambaexpression";
            };
            string objj = obj.Invoke("dhruvi");
            Console.WriteLine(objj);


        }

    }
}
