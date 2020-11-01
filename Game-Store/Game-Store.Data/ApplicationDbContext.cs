using Game_Store.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Game_Store.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .Property(u => u.UserName).HasMaxLength(100);

            builder.Entity<UserGame>()
                .HasKey(g => new { g.ApplicationUserId, g.GameId });

            builder.Entity<UserGame>()
                .HasOne(ug => ug.ApplicationUser)
                .WithMany(u => u.UserGames)
                .HasForeignKey(ug => ug.ApplicationUserId);

            builder.Entity<UserGame>()
               .HasOne(ug => ug.Game)
               .WithMany(g => g.UserGames)
               .HasForeignKey(ug => ug.GameId);
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<UserGame> UserGames { get; set; }
    }
}
