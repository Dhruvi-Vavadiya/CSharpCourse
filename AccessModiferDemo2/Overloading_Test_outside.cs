using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModiferDemo2
{
    internal class Overloading_Test_outside 
    {

        static void Main(string[] args)
        {
            CSharpCourse.overloading_out oto = new CSharpCourse.overloading_out();
           
            oto.Test(5);
            oto.Test(8.4f);
            oto.Test(5.5);
            oto.Test("sds");
           // oto.Test(3,'d');
            
            
        }
    }
}
