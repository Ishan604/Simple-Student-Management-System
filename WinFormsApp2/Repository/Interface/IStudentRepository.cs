using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Models;

namespace WinFormsApp2.Repository.Interface
{
    public interface IStudentRepository
    {
        List<StudentModel> GetStudents();
        void AddStudent(StudentModel student);
        void UpdateStudent(StudentModel student);
        void DeleteStudent(int id);
    }
}
