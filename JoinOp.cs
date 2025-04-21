using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpCourse
{
    public enum GradeLevel
    {
        FirstYear = 1,
        SecondYear,
        ThirdYear,
        FourthYear
    };

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public GradeLevel Year { get; set; }
        public List<int> Scores { get; set; }

        public int DepartmentID { get; set; }
    }

    public class Teacher
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int TeacherID { get; set; }
        public string City { get; set; }
    }
    public class Department
    {
        public string Name { get; set; }
        public int DepartmentID { get; set; }

        public int TeacherID { get; set; }
    }

    internal class JoinOp
    {
        public enum GradeLevell
        {
            FirstYear = 1,
            SecondYear,
            ThirdYear,
            FourthYear
        };
        public static void AskForBouns(GradeLevell e)
        {

            switch (e)

            {

                case GradeLevell.FirstYear:

                    Console.WriteLine("You already get enough cash!");

                    break;
                case GradeLevell.SecondYear:

                    Console.WriteLine("You already get SecondYear cash!");

                    break;

                case GradeLevell.ThirdYear:

                    Console.WriteLine("You already get enough cash!");

                    break;
            }

        }
        public static void Main(string[] args)
        {
            JoinOp jop = new JoinOp();
            GradeLevell gradeLevell;
            gradeLevell = GradeLevell.SecondYear;
            

            JoinOp.AskForBouns(gradeLevell);


            List<Student> students = new List<Student>();
            List<Department> departments = new List<Department>();
            List<Teacher> teachers = new List<Teacher>();

            students.Add(new Student { ID = 101, DepartmentID = 1, FirstName = "bhautika", LastName = "patel", Scores = new List<int> { 1, 2, 3, 4, 5 }, Year = GradeLevel.FourthYear });
            students.Add(new Student { ID = 102, DepartmentID = 2, FirstName = "riya", LastName = "kho", Scores = new List<int> { 8, 6, 4, 7, 9 }, Year = GradeLevel.SecondYear });
            students.Add(new Student { ID = 103, DepartmentID = 2, FirstName = "nikisha", LastName = "jariwala", Scores = new List<int> { 1, 2, 3, 4, 5 }, Year = GradeLevel.FourthYear });

            departments.Add(new Department { DepartmentID = 1, Name = "mobile", TeacherID = 11 });
            departments.Add(new Department { DepartmentID = 2, Name = "web", TeacherID = 12 });
            departments.Add(new Department { DepartmentID = 3, Name = "fultter", TeacherID = 13 });

            teachers.Add(new Teacher { TeacherID = 11, First = "bhautika", Last = "patel", City = "baroda" });
            teachers.Add(new Teacher { TeacherID = 12, First = "niki", Last = "jariwala", City = "pune" });
            teachers.Add(new Teacher { TeacherID = 13, First = "riya", Last = "khokhariya", City = "pune" });

            var queryy =
      from student in students
      join department in departments on student.DepartmentID equals department.DepartmentID into gj
      from subgroup in gj.DefaultIfEmpty()
      select new
      {
          student.FirstName,
          student.LastName,
          Department = subgroup?.Name ?? string.Empty
      };

            foreach (var v in queryy)
            {
                Console.WriteLine($"{v.FirstName:-15} {v.LastName:-15}: {v.Department}");
            }

            //var group_dept_stud = from dept in departments
            //                      join stud in students
            //                      on dept.DepartmentID equals stud.DepartmentID
            //                      into gj
            //                      from substudnet in gj
            //                      select new
            //                      {
            //                          deptname = dept.Name,
            //                          studname = $"{substudnet.FirstName}  {substudnet.LastName}"

            //                      };

            var group_dept_stud = from dept in departments
                                  join stud in students
                                  on dept.DepartmentID equals stud.DepartmentID into studentgroup
                                  select new
                                  {
                                      deptname = dept.Name,
                                      studname = studentgroup
                                  };

            //var group_dept_stud = departments.GroupJoin(students,
            //                dept => dept.DepartmentID,
            //                stud => stud.DepartmentID,
            //                (de, studname) => new { deptname = de.Name , studname = studname }

            //    );

            foreach (var v in group_dept_stud)
            {
                Console.WriteLine("===> " + v.deptname + " <===");
                foreach (Student stud in v.studname)
                {
                    Console.WriteLine($"{stud.FirstName} : {stud.LastName}");

                }

            }
            foreach (var i in group_dept_stud)
            {
                // Console.WriteLine($" dept name :- {i.deptname} || stud name :- {i.studname} ");
            }


            var query = from stud in students
                        join dept in departments
                        on stud.DepartmentID equals dept.DepartmentID
                        join tech in teachers
                        on dept.TeacherID equals tech.TeacherID
                        select new
                        {
                            studname = stud.FirstName + " " + stud.LastName,
                            deptname = dept.Name,
                            techname = tech.First + " " + tech.Last
                        };

            foreach (var item in query)
            {
                // Console.WriteLine($"stud_nm :- {item.studname}|| dept_nm :- {item.deptname} || tech_nm :- {item.techname}");
            }

            //IEnumerable<string> composite_key = from tech in teachers
            //                      join stud in students on new
            //                      {
            //                          FirstName = tech.First,
            //                          LastName = tech.Last
            //                      } equals new
            //                      {
            //                          stud.FirstName,
            //                          stud.LastName
            //                      }select tech.TeacherID+" "+tech.First + " " + tech.Last;

            IEnumerable<string> composite_key =
                teachers.Join(students,
                             tech => new { FirstName = tech.First, LastName = tech.Last },
                             stud => new { stud.FirstName, stud.LastName },
                             (t, s) => $"{t.First} {t.Last}"
                );

            string name = "";
            foreach (string item in composite_key)
            {
                name += $"{item}\r\n";
            }
            // Console.WriteLine(name);

            IEnumerable<IEnumerable<Department>> departmentGroups =
                            teachers.GroupJoin(departments,
                            tech => tech.TeacherID, dept => dept.TeacherID,
                            (t, d) => d);
            foreach (IEnumerable<Department> deptGrop in departmentGroups)
            {
                //Console.WriteLine("Group");
                foreach (Department dept in deptGrop)
                {
                    //  Console.WriteLine($"  - {dept.Name}, {dept.TeacherID}");
                }
            }

            IEnumerable<IEnumerable<Student>> studnetGroups =
                               from dept in departments
                               join stu in students
                               on dept.DepartmentID equals stu.DepartmentID
                               into studGroup
                               select studGroup;

            foreach (IEnumerable<Student> studGroup in studnetGroups)
            {
                //Console.WriteLine("Group");
                foreach (Student student in studGroup)
                {
                    //    Console.WriteLine($"  - {student.FirstName}, {student.LastName}");
                }
            }


            var tech_dept = teachers.Join(departments,
                        dept => dept.TeacherID,
                        tech => tech.TeacherID,
                        (t, d) => new
                        {
                            techname = t.First + " " + t.Last,
                            deptid = d.DepartmentID,
                            deptname = d.Name
                        });
            foreach (var item in tech_dept)
            {
                //Console.WriteLine($"dept id :- {item.deptid} department :- {item.deptname} techname :- {item.techname}");
            }

            var dept_tech = from dept in departments
                            join tech in teachers
                            on dept.TeacherID equals tech.TeacherID
                            select new
                            {
                                did = dept.DepartmentID,
                                dname = dept.Name,
                                techname = tech.First + " " + tech.Last
                            };
            foreach (var item in dept_tech)
            {
                //  Console.WriteLine($"deptid :-{item.did} deptname :- {item.dname} techname :- {item.techname}");
            }

            Console.WriteLine("==============================");
            var stu_dept = from stu in students
                           join dept in departments
                           on stu.DepartmentID equals dept.DepartmentID
                           select new
                           {
                               stu.ID,
                               Fullname = stu.FirstName + " " + stu.LastName,
                               deptname = dept.Name,
                               score = string.Join(",", stu.Scores),
                               Year = stu.Year
                           };
            foreach (var item in stu_dept)
            {
                Console.WriteLine($"student id :- {item.ID} name :- {item.Fullname} department :- {item.deptname} Score :- {item.score} year :- {item.Year}");
            }




        }
    }
}
