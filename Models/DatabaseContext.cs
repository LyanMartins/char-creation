using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MySQL.Data.EntityFrameworkCore;

namespace char_creation.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseMySQL("Server=sql10.freemysqlhosting.net;DataBase=sql10340412;Uid=sql10340412;Pwd=BTPmQdaDNg");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Character>().HasKey(t => t.Id);

        }
        
    }
}