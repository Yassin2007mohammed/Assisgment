using Microsoft.EntityFrameworkCore;
using Quiz.Models.Entites;

namespace Quiz.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Assigment> Assigments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assigment>()
                .HasOne(x => x.Subjects)
                .WithMany(c => c.Assigments)
                .HasForeignKey(i => i.subid);


            modelBuilder.Entity<Assigment>()
                .HasOne(x => x.Teacher)
                .WithMany(c => c.Assigments)
                .HasForeignKey(v => v.Tid);


        }
    }
}
