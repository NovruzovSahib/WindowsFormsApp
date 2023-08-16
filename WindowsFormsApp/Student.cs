using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Student
    {
        public Student()
        {
            _Id++;
            Id = _Id;
        }
        private static int _Id;
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Id + " " + StudentName+ " " + StudentSurname+ " " + Age;
        }
    }
}
