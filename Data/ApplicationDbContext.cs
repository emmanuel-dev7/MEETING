using MEETING.lesClasses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MEETING.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Organisateur> Organisateur { get; set; }
        public DbSet<Provenance> Provenance { get; set; }
        public DbSet<Relecteur> Relecteur { get; set; }
        public DbSet<Participant> Participant { get; set; }
        public DbSet<Auteur> Auteur { get; set; }
        public DbSet<Conference> Conference { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<ArticleRelu> ArticleRelu { get; set; }
        public DbSet<ParticipantConfe> ParticipantConfe { get; set; }
        public DbSet<AuteurProvenance> AuteurProvenance { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customize the ASP.NET Identity model and override the defaults
            builder.Entity<IdentityRole>(entity =>
            {
                entity.Property(m => m.Name).HasMaxLength(256);
                entity.Property(m => m.NormalizedName).HasMaxLength(256);
            });

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.Property(m => m.UserName).HasMaxLength(256);
                entity.Property(m => m.NormalizedUserName).HasMaxLength(256);
                entity.Property(m => m.Email).HasMaxLength(256);
                entity.Property(m => m.NormalizedEmail).HasMaxLength(256);
                entity.Property(m => m.ConcurrencyStamp).HasColumnType("longtext");
            });

            builder.Entity<IdentityUser>(entity =>
            {
                entity.Property(m => m.UserName).HasMaxLength(256);
                entity.Property(m => m.NormalizedUserName).HasMaxLength(256);
                entity.Property(m => m.Email).HasMaxLength(256);
                entity.Property(m => m.NormalizedEmail).HasMaxLength(256);
                entity.Property(m => m.ConcurrencyStamp).HasColumnType("longtext");
            });

            // Apply similar customizations to other Identity tables if necessary
        }
    }
}
