using BootcampIntern.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace BootcampIntern.Infrastructure
{
    public class BootcampLegendDbContext : DbContext
    {
        public BootcampLegendDbContext(DbContextOptions<BootcampLegendDbContext> options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterSkill> CharacterSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
