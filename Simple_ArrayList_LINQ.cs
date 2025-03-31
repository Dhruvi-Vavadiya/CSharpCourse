using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    internal class Simple_ArrayList_LINQ
    {
        static void Main(string[] args)
        {
            //TwoDatabase();

            string[] names = new String[] { "jatin", "mahesh", "puja", "dhruvi", "priyanka" };

            var newName = from n in names where n.ToLower().Contains("a") select n;

            //var newName = names.Where(n=>n.Contains("i")).Where(m=>m.Contains("d")).ToList();

            //var ame=from d in names select d.Length; //LINQ

            var ame = names.Select(s => s.Length).ToArray(); //Lemda

            foreach (string i in newName)
            {
                Console.WriteLine(i);
            }
            foreach (int i in ame)
            {
                Console.WriteLine(i);
            }

            int[] num = new int[] { 1, 2, 3, 4, 5 };
            var nummresult = from n in num where n >= 2 select n;
            Console.WriteLine("--------------");
            foreach (int i in nummresult)
            {
                Console.WriteLine(i);
            }




            /////////////////
            void TwoDatabase()
            {
                string sqlServerConnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Planet\\OneDrive\\Documents\\dhruvi.mdf;Integrated Security=True;";
                string mySqlConnString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_class_stud_foreginkey;Integrated Security=True;";

                DataTable dt_stud = new DataTable();
                DataTable dt_class = new DataTable();

                // Fetch data from SQL Server
                using (SqlConnection sqlConn = new SqlConnection(sqlServerConnString))
                {
                    string sqlQuery = "SELECT Id, nm,des,dob FROM studnet";
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                    sqlConn.Open();
                    sqlAdapter.Fill(dt_stud);
                }

                // Fetch data from MySQL
                using (SqlConnection mySqlConn = new SqlConnection(mySqlConnString))
                {
                    string mySqlQuery = "SELECT classId, classname FROM class";
                    SqlDataAdapter mySqlAdapter = new SqlDataAdapter(mySqlQuery, mySqlConn);
                    mySqlConn.Open();
                    mySqlAdapter.Fill(dt_class);
                }

                var result = from tblclass in dt_class.AsEnumerable()
                             join tblstud in dt_stud.AsEnumerable()
                             on tblclass.Field<int>("classId") equals tblstud.Field<int>("Id") into studentGroup
                             from sql in studentGroup.DefaultIfEmpty()  // Ensures RIGHT JOIN behavior
                             select new
                             {
                                 Id = sql != null ? sql.Field<int>("Id") : 0,
                                 Name = sql != null ? sql.Field<string>("nm") : "No Student",
                                 des = sql != null ? sql.Field<string>("des") : "N/A",
                                 ClassName = tblclass.Field<string>("classname"),
                                 dob = sql != null && !sql.IsNull("dob") ? sql.Field<DateTime?>("dob") : null  // Handle null date
                             };
                // Display result
                foreach (var item in result)
                {
                    string formattedDob = item.dob.HasValue ? item.dob.Value.ToString("yyyy-MM-dd") : "No DOB";
                    Console.WriteLine($"Date: {formattedDob}, ID: {item.Id}, Name: {item.Name}, Description: {item.des}, Class Name: {item.ClassName}");
                }

            }
            ////////////////

        }


       

    }
}
