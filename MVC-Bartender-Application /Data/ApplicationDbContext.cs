using Microsoft.EntityFrameworkCore;
using MVC_Bartender_Application.Models;

namespace MVC_Bartender_Application.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cocktail> Cocktails { get; set; }
    public DbSet<Order> Orders { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cocktail>().HasData(
            new Cocktail
            {
                Id = 1,
                Name = "Old Fashioned",
                Price = 14.00m
            },
            
            new Cocktail
            {
                Id = 2,
                Name = "Margarita",
                Price = 13.00m
            },
            
            new Cocktail
            {
                Id = 3,
                Name = "Martini",
                Price = 15.00m
            },
            
            new Cocktail
                {
                    Id = 4,
                    Name = "Manhattan",
                    Price = 15.00m
                },
                
            new Cocktail
                {
                    Id = 5,
                    Name = "Negroni",
                    Price = 14.00m
                },
                
            new Cocktail
                {
                    Id = 6,
                    Name = "Bloody Mary",
                    Price = 12.00m
                },
                
            new Cocktail
                {
                    Id = 7,
                    Name = "Mojito",
                    Price = 12.00m
                },
                
            new Cocktail
                {
                    Id = 8,
                    Name = "Aperol Spritz",
                    Price = 13.00m
                },
                
            new Cocktail
                {
                    Id = 9,
                    Name = "Daiquiri",
                    Price = 12.00m
                },
                
            new Cocktail
                {
                    Id = 10,
                    Name = "Moscow Mule",
                    Price = 11.00m
                }
        );
    }
}