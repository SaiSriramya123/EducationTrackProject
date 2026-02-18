using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EducationTrackProject.Models;

namespace EducationTrackProject.Data
{
    public class EducationTrackProjectContext : DbContext
    {
        public EducationTrackProjectContext (DbContextOptions<EducationTrackProjectContext> options)
            : base(options)
        {
        }

        public DbSet<EducationTrackProject.Models.Assessment> Assessment { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.Attendance> Attendance { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.Content> Content { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.Course> Course { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.Module> Module { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.Notification> Notification { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.Instructor> Instructor { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.Coordinator> Coordinator { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.Student> Student { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.AcademicReport> AcademicReport { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.StudentAnswer> StudentAnswer { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.Enrollment> Enrollment { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.Performance> Performance { get; set; } = default!;
        public DbSet<EducationTrackProject.Models.Question> Question { get; set; } = default!;
    }
}
