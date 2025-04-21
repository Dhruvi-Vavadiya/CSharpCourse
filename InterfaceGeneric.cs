using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse;

namespace CSharpCourse
{
    public interface IEntity
    {
        int Id { get; set; }
        void Display();
    }

    public class Students : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine($"Student: {Id}, {Name}");
        }
    }

    public class Teachers : IEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; }

        public void Display()
        {
            Console.WriteLine($"Teacher: {Id}, {Subject}");
        }
    }

    public class EntityManager<T> where T : IEntity
    {
        private List<T> eny = new List<T>();

        public void Add(T e)
        {
            eny.Add(e);
        }

        public void DisplayAll()
        {
            foreach (var e in eny)
            {
                e.Display();
            }
        }
    }


    internal class InterfaceGeneric
    {
        public static void Main(string[] args)
        {
            EntityManager<Students> studentManager = new EntityManager<Students>();
            studentManager.Add(new Students { Id = 1, Name = "Alice" });
            studentManager.Add(new Students { Id = 2, Name = "Bob" });

            


            EntityManager<Teachers> teacherManager = new EntityManager<Teachers>();
            teacherManager.Add(new Teachers { Id = 101, Subject = "Math" });
            teacherManager.Add(new Teachers { Id = 102, Subject = "Science" });


            Console.WriteLine("Students:");
            studentManager.DisplayAll();

            Console.WriteLine("Teachers:");
            teacherManager.DisplayAll();

        }
    }
}
