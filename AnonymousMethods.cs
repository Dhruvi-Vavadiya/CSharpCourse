using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    public delegate string grettingDel(string name);
    internal class AnonymousMethods
    {
        // simple function
        public static string gettingMsg(string name)
        {
            return "Hello  " + name + "  very good morning";
        }
        static void Main(string[] args)
        {
            // simple function with delegate
            grettingDel obj = new grettingDel(gettingMsg);
            string str = obj("dhruvi");
            Console.WriteLine(str);


            // anoonymous methos using delegate
            grettingDel objj = delegate (string nametrd)
            {
                return "Hello this   " + nametrd + "  anonymous method";
            };
            string strr = objj.Invoke("dhruvi");
            Console.WriteLine(strr);
        }
    }
}
