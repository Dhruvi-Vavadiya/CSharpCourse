using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    public class MethodOverriding
    {
        public void show(int i) => Console.WriteLine("show method from [parent] class :: " +i);
        
        //overridable virtual key word
        public virtual void hide(int i) => Console.WriteLine("virtual hide mthod from [parent] class" + i);
    }

    public class LoadChild : MethodOverriding
    {
        //overloading parent show method in child class
        public void show(string s) => Console.WriteLine("show meth from [Child] class  : "  + s);

        // do not override child class hide method  then by defualt call the parent hide mthod
        // Chance to change the hide metod logic
       //overriding parent test mthod in child class
        public override void hide(int a) => Console.WriteLine("override hide mthod from [Child] class ::- " +a);
        static void Main(string[] args)
        {
            LoadChild lc = new LoadChild();
            lc.show(6); //parent
            lc.show("nency"); //child
            lc.hide(8); //child
            Console.WriteLine("===============================");

            MethodOverriding meth_load = new LoadChild();
            meth_load.show(5); //run parent class
            meth_load.hide(5); //execute child class

            Console.WriteLine("===============================");


            //MethodOverriding moverriding =new MethodOverriding();
            //moverriding.show(200);
            //moverriding.hide(200);


        }       
    }
}
