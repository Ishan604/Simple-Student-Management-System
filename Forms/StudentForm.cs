using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Models;
using WinFormsApp2.Repository.Interface;
using WinFormsApp2.Repository.Service;

namespace WinFormsApp2.Forms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClerDetails()
        {
            txtid.Clear();
            txtname.Clear();
            txtage.Clear();
            txtcity.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new StudentModel();
                student.Name = txtname.Text;
                student.Age = txtage.Text;
                student.City = txtcity.Text;

                IStudentRepository repository = new StudentRepository();
                repository.AddStudent(student);
                MessageBox.Show("Successfully add the student", "Student!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClerDetails();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            IStudentRepository repository = new StudentRepository();
            dgvstudentdetails.DataSource = repository.GetStudents();
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            ClerDetails();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            IStudentRepository repository = new StudentRepository();
            try
            {
                var student = new StudentModel();
                student.Id = Convert.ToInt32(txtid.Text);
                student.Name = txtname.Text;
                student.Age = txtage.Text;
                student.City = txtcity.Text;
                repository.UpdateStudent(student);
                MessageBox.Show("Successfully updated the student", "Student!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClerDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            IStudentRepository repository = new StudentRepository();
            try
            {
                var student = new StudentModel();
                student.Id = Convert.ToInt32(txtid.Text);
                repository.DeleteStudent(student.Id);
                MessageBox.Show("Successfully deleted the student", "Student!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClerDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvstudentdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvstudentdetails.Rows[e.RowIndex];
                txtid.Text = row.Cells["Id"].Value.ToString();
                txtname.Text = row.Cells["Name"].Value.ToString();
                txtage.Text = row.Cells["Age"].Value.ToString();
                txtcity.Text = row.Cells["City"].Value.ToString();
            }
        }
    }
}

//Fluent validation is not used in this code snippet, but it can be integrated for validating the input fields before performing operations like add, edit, or delete.
//ghost doc is a tool that can be used to generate documentation comments based on the code structure, but it is not directly related to this code snippet.
