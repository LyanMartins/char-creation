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
            modelBuilder.Entity<Character>().HasOne(t => t.characterLineage);
            modelBuilder.Entity<Character>().HasOne(t => t.profission);

            modelBuilder.Entity<CharacterLineage>().HasKey(t => t.Id);
            modelBuilder.Entity<CharacterLineage>().HasOne(t => t.lineage);
           


            modelBuilder.Entity<Lineage>().HasKey(t => t.Id);
            modelBuilder.Entity<Lineage>().HasOne(t => t.lineageAtributtes);            
            
            modelBuilder.Entity<LineageAtributtes>().HasKey(t => t.Id);
            modelBuilder.Entity<Atributtes>().HasKey(t => t.Id);

            modelBuilder.Entity<Profission>().HasKey(t => t.Id);

            modelBuilder.Entity<Ability>().HasKey(t => t.Id);
            
            modelBuilder.Entity<CharacterAbility>().HasKey(t => new{ t.Id, t.abilityId, t.characterId});
            modelBuilder.Entity<CharacterAbility>().HasOne(t => t.ability)
                    .WithMany(tp => tp.characterAbility)
                    .HasForeignKey(f => f.abilityId);
            modelBuilder.Entity<CharacterAbility>().HasOne(t => t.character)
                    .WithMany(tp => tp.characterAbility)
                    .HasForeignKey(f => f.characterId);

            
        }
        
    }
}