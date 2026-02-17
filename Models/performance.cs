using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationTrackProject.Models
{
    public class performance
    {
        
            [Key]
            public int ProgressID { get; set; }  // unique code for each course

            public int EnrollmentId { get; set; } //id for student aftr enrooling, with this we can get details
            [Column(TypeName = "decimal(5,2)")]
            public decimal CompletionPercentage { get; set; }

            public DateTime LastUpdated { get; set; }
            [Column(TypeName = "decimal(5,2)")]
            public decimal AvgScore { get; set; }

        }
    }

