using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationTrackProject.Models
{
    public class AcademicReport
    {
        [Key]
        public int ReportId { get; set; }
        public string Scope { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal CompletionRate { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal AvgScore { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal DropOutRate { get; set; }

        public DateTime GeneratedDate { get; set; }

    }
}

