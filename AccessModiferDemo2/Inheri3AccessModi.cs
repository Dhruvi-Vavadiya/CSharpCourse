using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModiferDemo2
{
    //case 4 :- consuming menber of class from child class of same project (Private ,Internal N)
    //only inherited by public access modifiers classes
    internal class Inheri3AccessModi : CSharpCourse.AccessModifiers
    {
        static void Main()
        {
            Inheri3AccessModi i = new Inheri3AccessModi();
            i.MPublic();
            i.MProtected();
            i.MProtectedInternal();
            //[ internal method ] can not inherit
        }
    }
}
