
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	namespace EducationTrackProject.Models
	{
		public class Course
		{
			[Key]
			[Required]
			public string CourseId { get; set; }
			[Required]

			public string CourseName { get; set; }

			[Required]
			[ForeignKey("Programs")]
			public string Program_ID { get; set; }

			public string Description { get; set; }
			[Required]
			public int CreditPoints { get; set; }
			[Required]
			public bool CourseStatus { get; set; }

			[Required]

			public DateTime CourseDuration { get; set; }


		}
	}


