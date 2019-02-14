using System;
using System.ComponentModel.DataAnnotations;

namespace EFModelEntity
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }
        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }
    }
}
