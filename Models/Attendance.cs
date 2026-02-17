using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationTrackProject.Models
{
	//[Table("Attendance")]
	public class Attendance
	{
		[Key]
		public string AttendanceID { get; set; }

		[Required]
		[ForeignKey("Enrollment")]
		public string EnrollmentID { get; set; }
		public Enrollment Enrollment { get; set; }

		[Required]
		public DateTime SessionDate { get; set; }
		[Required]
		public string Mode { get; set; }
		[Required]
		public bool Status { get; set; }
	}
}
