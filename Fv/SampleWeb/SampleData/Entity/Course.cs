using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SampleData.Core
{
    public class Course : IEntity<Guid>
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required, DataType(DataType.Text), StringLength(50)]
        public string CourseName { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
