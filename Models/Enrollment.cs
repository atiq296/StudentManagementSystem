using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        // Foreign Keys
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        // Navigation Properties
        public Student Student { get; set; }
        public Course Course { get; set; }

        [Range(0, 100)]
        public int? Grade { get; set; } // Nullable (student may not have a grade yet)
    }
}
