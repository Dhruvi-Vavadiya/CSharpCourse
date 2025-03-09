using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    internal class Inheri2AccessModi
    {
        //case 3 :- consuming menbers of class from non-child class of same project (protected,Private N)
        static void Main(string[] args)
        {
            AccessModifiers modi = new AccessModifiers();
            //Private or protected member or method not use
            //private do not use out side the class
            //protected not use becaue not inherite the AccssModifiers class
            modi.MPublic();
            modi.MIntenal();
            modi.MProtectedInternal();  
        }
    }
}
