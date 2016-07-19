using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MetierIdentification.Models;

namespace Identification.Models
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant plus de propriétés à votre classe ApplicationUser ; consultez http://go.microsoft.com/fwlink/?LinkID=317594 pour en savoir davantage.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Notez qu'authenticationType doit correspondre à l'élément défini dans CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Ajouter les revendications personnalisées de l’utilisateur ici
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>().ToTable("Account").Property(p => p.Id).HasColumnName("AccountID");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("userClaim");
        }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Invitation> Invitation { get; set; }
        public DbSet<Segment> Segment { get; set; }
        public DbSet<SousSegment> SousSegment { get; set; }
        public DbSet<Questionnaire> Questionnaire { get; set; }
        public DbSet<Etablissement> Etablissement { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Reponse> Reponse { get; set; }
        public DbSet<Audit> Audit { get; set; }
        public DbSet<TypeQuestionnaire> TypeQuestionnaire { get; set; }
        public DbSet<Prestations> Prestations { get; set; }
        public DbSet<Banquet> Banquet { get; set; }
        public DbSet<Compte> Compte { get; set; }
        public DbSet<Seminaire> Seminaire { get; set; }
        public DbSet<Sejour> Sejour { get; set; }
    }
}