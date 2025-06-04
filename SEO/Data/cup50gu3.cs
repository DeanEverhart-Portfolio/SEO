using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SEO.Models;

namespace SEO.Data
{
    public class cup50gu3 : IdentityDbContext
    {
        public cup50gu3(DbContextOptions<cup50gu3> options)
            : base(options)
        {
        }
        public DbSet<SEO.Models.Contact> Contact { get; set; } = default!;
        public DbSet<SEO.Models.ContactClient> ContactClient { get; set; } = default!;
        public DbSet<SEO.Models.Domain> Domain { get; set; } = default!;
        public DbSet<SEO.Models.Ahref> Ahref { get; set; } = default!;
        public DbSet<SEO.Models.Hog> Hog { get; set; } = default!;
    }
}
