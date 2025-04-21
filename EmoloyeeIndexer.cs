using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    internal class EmoloyeeIndexer
    {
        int Eno;
        double salary;
        string Ename, Location;

        public EmoloyeeIndexer(int eno, double sal, string enm, string loc)
        {
            this.Eno = eno;
            this.salary = sal;
            this.Ename = enm;
            this.Location = loc;
        }
        public void ToString()
        {
            Console.WriteLine($"eno :- {Eno} = ename :- {Ename} = salary :- {salary} = Location :- {Location}");
        }

        public object this[int index]
        {
            get
            {
                if (index == 11)
                    return Eno;
                if (index == 12)
                    return Ename;
                if (index == 13)
                    return salary;
                if (index == 14)
                    return Location;
                return null;
            }
            set
            {
                if (index == 101)
                    Eno = (int)value;
                if(index == 102)
                    Ename = (string)value;
                if(index== 103)
                    salary = (double)value;
                if(index == 104)
                    Location = (string)value;
            }
        }
        public object this[string name]
        {
            get
            {
                if (name == "e")
                    return Eno;
                if (name == "nm")
                    return Ename;
                if (name == "sal")
                    return salary;
                if (name == "loc")
                    return Location;
                if (name == null)
                    return null;
                else
                    return "null";
                return null;
            }
        }

        }

    public class TestEmployeeIndexer
    {
        static void Main(string[] args)
        {
            EmoloyeeIndexer emps = new EmoloyeeIndexer(101, 55500.55, "dhruvu", "surat");

            emps.ToString();

            Console.WriteLine("eno :- " + emps[11]);
            Console.WriteLine("ename :- " + emps[12]);
            Console.WriteLine("salary :- " + emps[13]);
            Console.WriteLine("location :- " + emps[14]);


            emps[101] = 11111111;
            emps[102] = "nency";
            emps[103] = 64.54;
            emps[104] = "pune";

            emps.ToString();

            Console.WriteLine("eno :- " + emps["e"]);
            Console.WriteLine("ename :- " + emps["nm"]);
            Console.WriteLine("salary :- " + emps["sal"]);
            Console.WriteLine("location :- " + emps["loc"]);


            Console.ReadLine();


        }
    }
}
