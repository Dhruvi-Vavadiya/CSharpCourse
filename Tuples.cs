using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace CSharpCourse
{
    public struct MyStruct
    {
        public double X { set; get; }
        public double Y { set; get; }
        public MyStruct(double x, double y)
        {
            X = x; Y = y;
        }

        public override string ToString()
        {
            return $"x value :- {X} y value :- {Y}";
        }
    }
    internal class Tuples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------file bytes-----------------");

            string path = @"D:\Msc_ICT\Sem2\C#\Console\CSharpCourse\InClassB.cs";


            //var fileessss = new DirectoryInfo(path)
            //                .GetFiles().Where(f => f.Length == 520).Select(f => f.Name).ToList();


            //foreach(var file in fileessss)
            //{
            //    Console.WriteLine(file);
            //}
            Console.WriteLine("------------calculate 10 integer-----------------");
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 85, 78, 665, 74, 86, 25, 85 };
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += numbers[i];
            }


            Console.WriteLine("Sum = " + total);
            Console.WriteLine("------------strucure-----------------");

            var p1 = new MyStruct(5.5, 10.4);
            Console.WriteLine(p1.X);


            //not working this .net version
            //var p2 = p1 with { X = 3.3 };
            //Console.WriteLine(p2);

            //MyStruct  p;
            //p.X = 3;
            //p.Y = 4;
            //Console.WriteLine($"({p.X}, {p.Y})");  // output: (3, 4)


            Console.WriteLine("-------------Local function for my created----------------");

            void getFunc(string nm)
            {

                int getnum(int idd)
                {
                    idd = idd * 5;
                    //Console.WriteLine(id);
                    return idd;
                }

                int id = 5;

                id = getnum(id);
                Console.WriteLine(id);
            }

            getFunc("ddd");

            Console.WriteLine("-------------Local Generic Function----------------");
            // Local Generic Function
            void MyMethod<MyValue>(MyValue values)
            {
                Console.WriteLine("Value is: " + values);
            }

            // Calling local generic function
            MyMethod<int>(123);
            MyMethod<string>("GeeksforGeeks");
            MyMethod<char>('G');
            MyMethod<double>(45453.5656);
            Console.WriteLine("------------Reflection practice-----------------");
            Console.WriteLine("\nReflection.MemberInfo");

            // Load the assembly (DLL)
            Assembly assembly = Assembly.LoadFrom("CSharpCourse.exe");
            
            
            Type myType = assembly.GetType("CSharpCourse.AccessModifiers"); // Replace with actual namespace.classname

            MethodInfo[] methods = myType.GetMethods();

            foreach (var method in methods)
            {
                //parameterinfo
                //fieldinfo
                Console.WriteLine($"{method.IsConstructor} is public.");
            }



            Console.WriteLine("------------Reflection-----------------");



            Type theType = Type.GetType("System.Reflection.Assembly");

            Console.WriteLine("\nSingle Type is ::-  {0}\n", theType);

            System.Reflection.Assembly o = System.Reflection.Assembly.Load("mscorlib.dll");

            Console.WriteLine("get name info ::-" + o.GetName());

            int ii = 42;

            System.Type type = ii.GetType();


            Console.WriteLine("type :-" + type);

            Console.WriteLine("-------------diffrent type pf tuple----------------");
            (int, string) pair1 = (1, "One");
            (int, string word) pair2 = (2, "Two");
            (int number, string word) pair3 = (3, "Three");
            (int Item1, string Item2) pair4 = (4, "Four");
            // Error: "Item" names do not match their position
            //(int Item2, string Item123) pair5 = (5, "Five");
            (int, string) pair6 = new ValueTuple<int, string>(6, "Six");
            ValueTuple<int, string> pair7 = (7, "Seven");
            Console.WriteLine($"{pair2.Item1}, {pair2.Item2}, {pair2.word}");
            Console.WriteLine("------------Tuple assignment and deconstruction-----------------");

            (int, double) t11 = (17, 3.14);
            (double First, double Second) t2 = (0.0, 1.0);
            t2 = t11;
            Console.WriteLine($"{nameof(t2)}: {t2.First} and {t2.Second}");

            (double A, double B) t3 = (2.0, 3.0);
            t3 = t2;
            Console.WriteLine($"{nameof(t3)}: {t3.A} and {t3.B}");
            //deconstruction
            var (destination, distance) = t3;
            Console.WriteLine($"Distance to {destination} is {distance} kilometers.");



            Console.WriteLine("-------------Use cases of tuples----------------");
            int[] xs = new int[] { 4, 7, 9 };
            var limits = FindMinMax(xs);
            Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");
            // Output:
            // Limits of [4 7 9] are 4 and 9

            int[] ys = new int[] { -9, 0, 67, 100 };
            var (minimum, maximum) = FindMinMax(ys);
            Console.WriteLine($"Limits of [{string.Join(" ", ys)}] are {minimum} and {maximum}");
            // Output:
            // Limits of [-9 0 67 100] are -9 and 100

            (int min, int max) FindMinMax(int[] input)
            {
                if (input is null || input.Length == 0)
                {
                    throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
                }

                // Initialize min to MaxValue so every value in the input
                // is less than this initial value.
                var min = int.MaxValue;
                // Initialize max to MinValue so every value in the input
                // is greater than this initial value.
                var max = int.MinValue;
                foreach (var i in input)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                    if (i > max)
                    {
                        max = i;
                    }
                }
                return (min, max);
            }


            Console.WriteLine("-----------Tuples as out parameters------------------");
            var limitss = new Dictionary<int, (int min, int max)>()
            {
                [2] = (5, 8),
                [4] = (5, 9),
                [8] = (7, 1)
            };
            if (limitss.TryGetValue(8, out var value))
            {
                Console.WriteLine(value.ToString());
            }


            Console.WriteLine("-------------Tuple equality----------------");

            Console.WriteLine((Display(1), Display(2)) == (Display(3), Display(4)));

            int Display(int s)
            {
                Console.WriteLine(s);
                return s;
            }
            Console.WriteLine("-----------gethashcode or tostring------------------");

            (double, int) t = (4.5, 3);
            Console.WriteLine(t.ToString());
            Console.WriteLine($"Hash code of {t} is {t.GetHashCode()}.");

            Console.WriteLine("-------------simple tuple , Tuple field names----------------");
            //(double, int) t1 = (4.2, 5);
            // (double dum, int num) t1 = (4.2, 5);
            var t1 = (dum: 4.2, num: 5);


            Console.WriteLine(t1);
            Console.WriteLine(t1.Item1);
            Console.WriteLine($"first :- {t1.dum} , Second :- {t1.num} ");


            var a = 1;
            var tup = (a, b: 2, 3);
            Console.WriteLine($"The 1st element is {tup.Item1} (same as {tup.a}).");
            Console.WriteLine($"The 2nd element is {tup.Item2}  (same as  {tup.b}).");
            Console.WriteLine($"The 3rd element is {tup.Item3}.");



        }
    }
}
