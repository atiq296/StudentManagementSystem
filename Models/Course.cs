using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Range(1, 5)] // Only 1–5 credits allowed
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
