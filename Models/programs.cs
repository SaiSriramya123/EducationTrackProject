using System.ComponentModel.DataAnnotations;

namespace EducationTrackProject.Models
{
    public class programs
    {
        [Key]
        public string Program_ID { get; set; }
        [Required]
        public string ProgramName { get; set; }
        [Required]
        public int AcademicYear { get; set; }
        [Required]
        public bool Status { get; set; }
		public virtual Course Course { get; set; }
	}
}

    

