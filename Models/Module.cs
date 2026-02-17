using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationTrackProject.Models
{
	//[Table("Module")]
	public class Module
	{
		[Key]
		public string ModuleID { get; set; }

		[Required]
		[ForeignKey("Course")]
		public string CourseID { get; set; }
		public Course Course { get; set; }

		[Required]
		public string Name { get; set; }
		[Required]
		public int SequenceOrder { get; set; }
		public string LearningObjectives { get; set; }
		//public ICollection<Content> Contents { get; set; }
	}
}