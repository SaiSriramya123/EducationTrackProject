using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationTrackProject.Models
{
	//[Table("Assessment")]
	public class Assessment
	{
		[Key]
		public string AssessmentID { get; set; }
		[Required]

		[ForeignKey("Course")]
		public string CourseID { get; set; }
		public Course Course { get; set; }

		[Required]
		public string Type { get; set; }
		[Required]
		//[Range(1, 1000)] 
		public int MaxMarks { get; set; }
		[Required]
		public DateTime DueDate { get; set; }
		[Required]
		public string Status { get; set; }
	}
}
