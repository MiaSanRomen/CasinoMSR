using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistoryPedia.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HistoryPedia.Models
{
    public class GameContext : IdentityDbContext<User>
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Change> Changes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<BlockInfo> BlocksInfo { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<FavoriteGame> FavoriteGames { get; set; }
        public DbSet<GameUserStatistic> GameUserStatistics { get; set; }

        public GameContext(DbContextOptions<GameContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
