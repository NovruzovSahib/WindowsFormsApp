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
    public partial class Form4 : Form
    {
        public DataGridView dataGridView;
        public Group group;
        public Form4(DataGridView _dataGridView,Group _group)
        {
            InitializeComponent();
            dataGridView = _dataGridView;
            group = _group;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int studentIdToUpdate = Convert.ToInt32(id.Text.Trim());

            if (studentIdToUpdate != -1)
            {
                Student updatedStudent = new Student()
                {
                    StudentName = name.Text.Trim(),
                    StudentSurname = surname.Text.Trim(),
                    Age = Convert.ToInt32(age.Text.Trim()),
                };
                group.UpdateStudent(studentIdToUpdate, updatedStudent);
                dataGridView.DataSource = null;
                dataGridView.DataSource = group.GetAllStudents();

                id.Text = string.Empty;
                name.Text = string.Empty;
                surname.Text = string.Empty;
                age.Text = string.Empty;
            }
        }

    }
}
