using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EducationTrackProject.Models;
using System.Collections;

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
		public IEnumerable Enrollment { get; internal set; }
	}
}
