using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Business.Interface;
using WinFormsApp2.Models;
using WinFormsApp2.Repository.Interface;
using WinFormsApp2.Repository.Service;

namespace WinFormsApp2.Business.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;
        

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public void AddStudent(StudentModel student)
        {
            _repo.AddStudent(student); //This means addstudent method of the repository
        }

        public void DeleteStudent(int id)
        {
            _repo.DeleteStudent(id);
        }

        public List<StudentModel> GetStudents()
        {
            return _repo.GetStudents();
        }

        public void UpdateStudent(StudentModel student)
        {
            _repo.UpdateStudent(student);
        }
    }
}
