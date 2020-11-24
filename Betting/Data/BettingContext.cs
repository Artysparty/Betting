using Betting.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Betting.Data
{
    class BettingContext : DbContext
    {
        public BettingContext()
        {
        }

        public BettingContext(DbContextOptions options)
            :base (options)
        {
        }

        public virtual DbSet<Bets> Bets { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Games> Games{ get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<PlayerStatistics> PlayerStatistics { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<Towns> Towns { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=LAPTOP-V6M1QK29;Database=Betting;Integrated Security=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PlayerStatistics>(e =>
                e.HasKey(ps => new { ps.PlayerId, ps.GameId }));

            builder.Entity<Colors>(e =>
                e.HasMany<Teams>(color => color.PrimaryKitColor).WithOne(team => team.PrimaryKitColor).OnDelete(DeleteBehavior.NoAction));

            builder.Entity<Colors>(e =>
                e.HasMany<Teams>(color => color.SecondaryKitColor).WithOne(team => team.SecondaryKitColor).OnDelete(DeleteBehavior.NoAction));

            builder.Entity<Teams>(e =>
                e.HasMany(t => t.HomeGames).WithOne(g => g.HomeTeam).OnDelete(DeleteBehavior.NoAction));

            builder.Entity<Teams>(e =>
                e.HasMany(t => t.AwayGames).WithOne(g => g.AwayTeam).OnDelete(DeleteBehavior.NoAction));
        }
    }
}
