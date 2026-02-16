using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationTrackProject.Models
{
	//[Table("Content")]
	public class Content
	{
		[Key]
		public string ContentID { get; set; }

		[Required]
		[ForeignKey("Module")]
		public string ModuleID { get; set; }
		//public Module Module { get; set; }

		[Required]
		public string ContentType { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public string ContentURI { get; set; }
		public TimeSpan? Duration { get; set; }
		[Required]
		public string Status { get; set; }
	}
}
