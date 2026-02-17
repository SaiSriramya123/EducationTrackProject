using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace EducationTrackProject.Models
{
	public class Notification
	{
		[Key] // Primary Key
		public int NotificationID { get; set; }

		[Required]
		[ForeignKey(StudentId)]
		public int StudentID { get; set; }

		[Required]
		[ForeignKey(InstructorId)]// Must have an Instructor ID
		public int InstructorID { get; set; }

		[Required]
		[ForeignKey(CoordinatorId)]// Must have a Coordinator ID
		public int CoordinatorID { get; set; }



		[Required] // Message cannot be null
		[StringLength(500)] // Limit message length
		public string Message { get; set; }

		[Required]
		[StringLength(100)] // Category name length
		public string Category { get; set; }

		[Required]
		[StringLength(50)] // Status like "Active", "Resolved"
		public string Status { get; set; }

		[Required]
		[DataType(DataType.DateTime)] // Ensure proper DateTime format
		public DateTime CreatedDate { get; set; }
		public virtual Instructor Instructor { get; set; }
		public virtual Coordinator Coordinator { get; set; }

	}
}
