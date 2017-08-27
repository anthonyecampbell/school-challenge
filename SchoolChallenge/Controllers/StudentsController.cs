using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using SchoolChallenge.Models;

namespace SchoolChallenge.Controllers
{
    [Route("[controller]/[action]")]
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            var studentsList = LoadStudents().ToList();
            return View(studentsList);
        }

        // method to load all students from the database
        public List<Student> LoadStudents()
        {
            var studentList = new List<Student>();

            using (var connection =
                new SqlConnection(
                    "Data Source=.\\SQLEXPRESS;Initial Catalog=SchoolChallengeDB;Trusted_Connection=True;MultipleActiveResultSets=true;")
            )
            {
                connection.Open();
                string sql = "Select * from Students";
                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student = new Student();
                            student.Id = Int32.Parse(reader["Id"].ToString());
                            student.StudentNumber = reader["StudentNumber"].ToString();
                            student.FirstName = reader["FirstName"].ToString();
                            student.LastName = reader["LastName"].ToString();
                            student.HasScholarship = Boolean.Parse(reader["HasScholarship"].ToString());

                            studentList.Add(student);
                        }
                    }
                }
            }
            return studentList;
        }
    }
}