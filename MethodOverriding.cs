using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    public class MethodOverriding
    {
        public void show() => Console.WriteLine("show method from methodoverriding class");
        
        //overridable virtual key word
        public virtual void hide() => Console.WriteLine("virtual hide mthod from methodoverriding class");
    }

    public class LoadChild : MethodOverriding
    {
        //overloading parent show method in child class
        public void show(int i) => Console.WriteLine("show meth from Loadchild class  : " + i);

        // do not override child class hide method  then by defualt call the parent hide mthod
        // Chance to change the hide metod logic
        //overriding
        //overriding parent test mthod in child class
        public override void hide() => Console.WriteLine("override hide mthod from loadchild class");
        static void Main(string[] args)
        {
            LoadChild lc = new LoadChild();
            lc.show();
            lc.hide();

            lc.show(6);
           
            
        }       
    }
}
