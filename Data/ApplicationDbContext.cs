using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SEO.Models;

namespace SEO.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SEO.Models.Contact>? Contact { get; set; }
        public DbSet<SEO.Models.Client>? Client { get; set; }
        public DbSet<SEO.Models.Domain>? Domain { get; set; }
        public DbSet<SEO.Models.Hog>? Hog { get; set; }
        public DbSet<SEO.Models.Ahref>? Ahref { get; set; }
        public DbSet<SEO.Models.ContactClient>? ContactClient { get; set; }
    }
}