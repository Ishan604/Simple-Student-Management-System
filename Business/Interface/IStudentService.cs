using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Models;

namespace WinFormsApp2.Business.Interface
{
    public interface IStudentService
    {
        List<StudentModel> GetStudents();
        void AddStudent(StudentModel student);
        void UpdateStudent(StudentModel student);
        void DeleteStudent(int id);
    }
}
