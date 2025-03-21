using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace sda.backend.minimalapi.Core.Auths.Models
{
    public class AuthenticationDbContext : IdentityDbContext<AuthenticationUser>
    {
        #region Constructors
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options) 
        { 
        }
        public AuthenticationDbContext()
        {
        }
        #endregion

        #region  Internal methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AuthenticationUser>().ToTable("AspNetUsers");
        }
        #endregion

        #region Properties
        public DbSet<AuthenticationUser> AuthenticationUsers { get; set; }
        #endregion
    }
}
