using MEETING.lesClasses;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MEETING.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
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
    }
}
