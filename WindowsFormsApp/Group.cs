using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupType { get; set; }
        public List<Student> students = new List<Student>();

        public Group(string gname,string gtype)
        {
            this.GroupName = gname;
            this.GroupType = gtype;
        }

        public void InsertStudent(Student model)
        {
            if (model!=null)
            {
                students.Add(model);
            }
        }
        public Student SearchStudent(int Id)
        {
            return students.FirstOrDefault(student => student.Id == Id);
        }

        public void UpdateStudent(int Id,Student newstudent)
        {
            Student oldstudent = students.FirstOrDefault(student => student.Id == Id);

            if (oldstudent!=null)
            {
                oldstudent.StudentName = newstudent.StudentName;
                oldstudent.StudentSurname = newstudent.StudentSurname;
                oldstudent.Age = newstudent.Age;
            }
        }
        public List<Student> GetAllStudents() => students;

        

    }
}
