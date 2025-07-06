using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Models;
using WinFormsApp2.Repository.Interface;

namespace WinFormsApp2.Repository.Service
{
    internal class StudentRepository : IStudentRepository
    {
        String connectionstring = "Server=DESKTOP-5CVPK75; Database=Student; Integrated Security=SSPI; Trusted_Connection=True; TrustServerCertificate=True;";
        public void AddStudent(StudentModel student)
        {
            using(SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "INSERT INTO studentdetails(name,age,city) VALUES(@name,@age,@city)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@age", student.Age);
                cmd.Parameters.AddWithValue("@city", student.City);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int id)
        {
            using(SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "DELETE FROM studentdetails WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<StudentModel> GetStudents()
        {
            var students = new List<StudentModel>();
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "SELECT * FROM studentdetails";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    var student = new StudentModel
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Name = reader["name"].ToString(),
                        Age = reader["age"].ToString(),
                        City = reader["city"].ToString()
                    };
                    students.Add(student);
                }
            }
            return students;
        }

        public void UpdateStudent(StudentModel student)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                var query = "UPDATE studentdetails SET name = @name, age = @age, city = @city WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", student.Id);
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@age", student.Age);
                cmd.Parameters.AddWithValue("@city", student.City);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
