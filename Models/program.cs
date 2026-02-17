using System.ComponentModel.DataAnnotations;

namespace EducationTrackProject.Models
{
    public class program
    {
        [Key]
        public int Program_ID { get; set; }
        [Required]
        public string ProgramName { get; set; }
        [Required]
        public int AcademicYear { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}

    

