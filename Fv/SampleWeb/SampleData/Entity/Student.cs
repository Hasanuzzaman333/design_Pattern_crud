using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SampleData.Core
{
    public class Student : IEntity<Guid>
    {
        [Key,Required,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required,DataType(DataType.Text),StringLength(50)]
        public string StudentName { get; set; }

        [Required]
        public double Age { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
