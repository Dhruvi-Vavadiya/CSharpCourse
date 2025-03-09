using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naresh_i_Technologies_Delegate
{
    internal class AccessModifiers
    {
        public void MPublic()
        {
            Console.WriteLine("Public method");
        }
        private void MPrivate()
        {
            Console.WriteLine("private method");
        }
        protected void MProtected()
        {
            Console.WriteLine("Protected method");
        }
        internal void MIntenal()
        {
            Console.WriteLine("internal method");
        }

        protected internal void MProtectedInternal()
        {
            Console.WriteLine("Protected internal method");
        }

        //case 1 :- consuming members of class from same class
        static void Main()
        {
            AccessModifiers acc = new AccessModifiers();
            acc.MPublic();
            acc.MPrivate();
            acc.MProtected();
            acc.MIntenal();
            acc.MProtectedInternal();

        }
    }
}
