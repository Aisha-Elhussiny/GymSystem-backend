using GymSystem_backend.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymSystem_backend.Contexts
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=10.211.55.2,1434;Database=GymDb;User Id=sa;Password=Route@2026SQL;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        public DbSet<Trainer> Trainers { get; set; } = default!;
        public DbSet<Member> Members { get; set; } = default!;
        public DbSet<Plan> Plans { get; set; } = default!;
        public DbSet<Session> Sessions { get; set; } = default!;
        public DbSet<MemberShip> MemberShips { get; set; } = default!;

    }
}
