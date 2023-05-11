using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Entities
{
    public class Course
    {
        public int id { get; set; }
        public string Title { get; set; }

        //public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>(); // (navigation prop) Many to Many By Convention

        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}
