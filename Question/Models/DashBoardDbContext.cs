using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Question.Models
{
    public class DashBoardDbContext : DbContext
    {
        public DbSet<SkillGroup> SkillGroups { get; set; }

        public DbSet<Questions> questions { get; set; }

        public DbSet<Answer> answers { get; set; }

    }
}