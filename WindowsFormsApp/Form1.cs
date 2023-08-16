using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Group group;  
        public Form1()
        {
            InitializeComponent();
            group = new Group("C#", "Programming");
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                StudentName = name.Text.Trim(),
                StudentSurname = surname.Text.Trim(),
                Age = Convert.ToInt32(age.Text.Trim()),
            };
            group.InsertStudent(student);
            Refresh(group.GetAllStudents());
        }

        private void Refresh(List<Student> students)
        {
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = students;
            name.Text = string.Empty;
            surname.Text = string.Empty;
            age.Text = string.Empty;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(dataGridView1,group);
            form4.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(group,dataGridView1);
            form3.Show();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(group.GetAllStudents(),dataGridView1);
            form2.Show();         
        }
    }
}
