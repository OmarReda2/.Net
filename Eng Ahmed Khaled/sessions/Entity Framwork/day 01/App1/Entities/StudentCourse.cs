using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Entities
{
    // fluent 
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }

    }


    // // Annotation
    //public class StudentCourse
    //{
    //    [ForeignKey("Student")]
    //    public int StudentId { get; set; }
    //    [ForeignKey("Course")]

    //    public Student Student { get; set; }
    //    public Course Course { get; set; }
    //    public int CourseId { get; set; }
    //    public int Grade { get; set; }

    //}

}
