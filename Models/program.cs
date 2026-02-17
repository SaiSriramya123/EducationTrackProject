using System.ComponentModel.DataAnnotations;

namespace EducationTrackProject.Models
{
    public class program
    {
        [Key]
        [Range(3,7,ErrorMessage = "program ID must be between 3 and 7.")]
         public int Program_ID { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z\s]{3,50}$",
            ErrorMessage = "Program name must be alphabetic and between 3–50 characters.")]
        public string ProgramName { get; set; }

        [Required]
        [RegularExpression(@"^\d{4}$",
            ErrorMessage = "Academicyear must be in 4 digits")]
        public int AcademicYear { get; set; }

        [RegularExpression(@"^\d{1,10}$",
            ErrorMessage = "Credits must be a nuumber.")]
        public int Credits { get; set; }

        public bool Status { get; set; }
        public virtual Course Course { get; set; }
        public virtual Module Module { get; set; }
        public virtual Attendance Attendance { get; set; }
    }
}

    

