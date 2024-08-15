using ConfigurationORM.Models;
using Microsoft.EntityFrameworkCore;

namespace ConfigurationORM.Context;

public class AppDbContext:DbContext
{
    public DbSet<Person>Persons { get; set; }
    public DbSet<Work>Works { get; set; }
    public DbSet<Car>Cars { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-UM6TF1M;Database=PMS;Integrated Security = true;Encrypt=false;");
        base.OnConfiguring(optionsBuilder); 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasKey("VinCode");
        modelBuilder.Entity<Car>().Property(x=>x.VinCode).HasMaxLength(14);
        modelBuilder.Entity<Car>().HasIndex(x=>x.EngineNumber).IsUnique();
        modelBuilder.Entity<Car>().Property(x => x.IsNew)
            .HasDefaultValue(false);
        base.OnModelCreating(modelBuilder);
    }
}

