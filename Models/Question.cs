using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationTrackProject.Models
{
	public class Question
	{
		[Key]
		[Required]
		public string QuestionId { get; set; }

		[Required]
		[RegularExpression(@"^(MCQS|TRUE/FALSE|DESCRIPTION)$", ErrorMessage = "Type must be Mcq's, True/False, Description.")]
		public string QuestionType { get; set; }

		[Required]
		[StringLength(500, ErrorMessage = "Question text cannot exceed 500 characters.")]
		public string QuestionText { get; set; }

		[Required]
		[StringLength(300, ErrorMessage = "Answer text cannot exceed 300 characters.")]
		public string AnswerText { get; set; }

		[Required]
		public int marks { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime createdDate { get; set; }

		[ForeignKey("Assessment")]
		public string AssessmentId { get; set; }
	}
}
