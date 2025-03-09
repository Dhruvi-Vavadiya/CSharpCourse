using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    //Public class can inherite AccessModiferDemo2.Inheri3AccessModi class
    public class AccessModifiers
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
        //internal only accesible by with in the same prject do not use outside the project
        internal void MIntenal()
        {
            Console.WriteLine("internal method");
        }

        protected internal void MProtectedInternal()
        {
            Console.WriteLine("Protected internal method");
        }

        //case 1 :- consuming members of class from same class (all Y)
        public static void Main(string[] args)

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
