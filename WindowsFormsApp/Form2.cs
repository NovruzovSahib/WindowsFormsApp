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
    public partial class Form2 : Form
    {
        private List<Student> students;
        private DataGridView datagridview;
        public Form2(List<Student> _students, DataGridView _dataGridView)
        {
            InitializeComponent();
            students = _students;
            datagridview = _dataGridView;
            comboBox1.DataSource = students;
        }
        private void delbtn_Click(object sender, EventArgs e)
        {
            Student student = comboBox1.SelectedItem as Student;
            students.Remove(student);

            comboBox1.DataSource = null;
            comboBox1.DataSource = students;

            datagridview.DataSource = "";
            datagridview.DataSource = students;
        }
    }
}
