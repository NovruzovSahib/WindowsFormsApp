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
    public partial class Form3 : Form
    {
        public Group group;
        private DataGridView dataGridView;
        public Form3(Group _group, DataGridView _dataGridView)
        {
            InitializeComponent();
            group = _group;
            dataGridView = _dataGridView;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            int searchid = Convert.ToInt32(search.Text.Trim());

            Student foundStudent = group.SearchStudent(searchid);

            if (foundStudent!=null)
            {
                dataGridView.DataSource = new List<Student> { foundStudent };
            }
        }



    }
}
