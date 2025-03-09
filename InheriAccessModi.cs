using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    internal class InheriAccessModi : AccessModifiers
    {
        //case 2 :- consuming menber of class from child class of same project (private N all Y)
        static void Main()
        {
            InheriAccessModi iacc = new InheriAccessModi();
            //not use private membet outside the class
            //icc.MPrivate();
            iacc.MPublic();
            iacc.MIntenal();
            //Ingerit the accessmodifiers class that's why use protected method
            iacc.MProtected();
            iacc.MProtectedInternal();
        }
    }
}
