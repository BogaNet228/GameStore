using Microsoft.EntityFrameworkCore;

namespace GameStore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Key> Keys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Games.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, Title = "Cyberpunk 2077", Price = 1999.99m, ImagePath = "Images/cyberpunk.png" },
                new Game { Id = 2, Title = "The Witcher 3", Price = 1099.99m, ImagePath = "Images/witcher3.jpg" },
                new Game { Id = 3, Title = "Dark Souls III", Price = 1599.99m, ImagePath = "Images/darksouls3.jpg" },
                new Game { Id = 4, Title = "Doom Eternal", Price = 1799.99m, ImagePath = "Images/doom_eternal.jpg" },
                new Game { Id = 5, Title = "Red Dead Redemption 2", Price = 2999.99m, ImagePath = "Images/rdr2.jpg" },
                new Game { Id = 6, Title = "Assassin's Creed Valhalla", Price = 1599.99m, ImagePath = "Images/valhalla.jpg" },
                new Game { Id = 7, Title = "Hades", Price = 799.99m, ImagePath = "Images/hades.jpg" },
                new Game { Id = 8, Title = "Control", Price = 1499.99m, ImagePath = "Images/control.jpg" },
                new Game { Id = 9, Title = "Resident Evil Village", Price = 3999.99m, ImagePath = "Images/re_village.jpg" },
                new Game { Id = 10, Title = "God of War", Price = 3999.99m, ImagePath = "Images/godofwar.jpeg" }

            );
            modelBuilder.Entity<Key>().HasData(
                // Cyberpunk 2077
                new Key { Id = 1, Code = "CYBER-KEY-123", GameId = 1 },
                new Key { Id = 2, Code = "CYBER-KEY-456", GameId = 1 },
                new Key { Id = 3, Code = "CYBER-KEY-789", GameId = 1 },

                // The Witcher 3
                new Key { Id = 4, Code = "WITCHER-KEY-123", GameId = 2 },
                new Key { Id = 5, Code = "WITCHER-KEY-456", GameId = 2 },
                new Key { Id = 6, Code = "WITCHER-KEY-789", GameId = 2 },

                // Dark Souls III
                new Key { Id = 7, Code = "DARKSOULS-KEY-123", GameId = 3 },
                new Key { Id = 8, Code = "DARKSOULS-KEY-456", GameId = 3 },

                // Doom Eternal
                new Key { Id = 9, Code = "DOOM-KEY-123", GameId = 4 },
                new Key { Id = 10, Code = "DOOM-KEY-456", GameId = 4 },
                new Key { Id = 11, Code = "DOOM-KEY-789", GameId = 4 },

                // Red Dead Redemption 2
                new Key { Id = 12, Code = "RDR-KEY-123", GameId = 5 },
                new Key { Id = 13, Code = "RDR-KEY-456", GameId = 5 },

                // Assassin's Creed Valhalla
                new Key { Id = 14, Code = "VALHALLA-KEY-123", GameId = 6 },
                new Key { Id = 15, Code = "VALHALLA-KEY-456", GameId = 6 },
                new Key { Id = 16, Code = "VALHALLA-KEY-789", GameId = 6 },

                // Hades
                new Key { Id = 17, Code = "HADES-KEY-123", GameId = 7 },
                new Key { Id = 18, Code = "HADES-KEY-456", GameId = 7 },

                // Control
                new Key { Id = 19, Code = "CONTROL-KEY-123", GameId = 8 },
                new Key { Id = 20, Code = "CONTROL-KEY-456", GameId = 8 },
                new Key { Id = 21, Code = "CONTROL-KEY-789", GameId = 8 },

                // Resident Evil Village
                new Key { Id = 22, Code = "RE-VILLAGE-KEY-123", GameId = 9 },
                new Key { Id = 23, Code = "RE-VILLAGE-KEY-456", GameId = 9 },

                // God of War
                new Key { Id = 24, Code = "GOW-KEY-123", GameId = 10 },
                new Key { Id = 25, Code = "GOW-KEY-456", GameId = 10 },
                new Key { Id = 26, Code = "GOW-KEY-789", GameId = 10 }
            );
        }
    }
}
