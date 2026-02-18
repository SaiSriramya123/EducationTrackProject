using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EducationTrackProject.Models
{
	public class Program
	{
		[Key]
		[Required]
		[StringLength(20, ErrorMessage = "Program ID must be up to 20 characters.")]
		public string ProgramID { get; set; }  // ✅ string primary key

		[Required]
		[StringLength(50, MinimumLength = 3)]
		[RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Program name must be alphabetic.")]
		public string ProgramName { get; set; }

		[Required]
		[RegularExpression(@"^\d{4}$", ErrorMessage = "Academic year must be 4 digits.")]
		public string AcademicYear { get; set; }  // ✅ string to allow regex

		[Required]
		[Range(1, 10, ErrorMessage = "Credits must be between 1 and 10.")]
		public int Credits { get; set; }

		public bool Status { get; set; }

		// Navigation properties
		public virtual ICollection<Course> Courses { get; set; }
		public virtual ICollection<Module> Modules { get; set; }
		public virtual ICollection<Attendance> Attendances { get; set; }
	}
}
