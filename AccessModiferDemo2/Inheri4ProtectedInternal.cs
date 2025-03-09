using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse;

namespace AccessModiferDemo2
{
    internal class Inheri4ProtectedInternal
    {
        //case 5 :- consuming menbers of class from non-child class of diffrent project(public Y)
       
        static void Main()
        {
            CSharpCourse.AccessModifiers ia = new CSharpCourse.AccessModifiers();
            ia.MPublic();
        }
       
        
    }
}
