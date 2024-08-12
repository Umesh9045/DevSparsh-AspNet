using DevSparsh.Areas.Admin.Models;
using DevSparsh.Areas.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DevSparsh.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Product> products { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        base.OnModelCreating(builder);

        builder.Entity<Product>().HasData(
           new Product
           {
               Id = 1,
               Name = "Diamond Solitaire Necklace",
               Description = "A stunning necklace featuring a single diamond solitaire pendant.",
               Category = "Necklace",
               ImageUrl = "Diamond Solitaire Necklace.jpg",
               Price = 1500
           },
           new Product
           {
               Id = 2,
               Name = "Emerald Stud Earrings",
               Description = "Elegant stud earrings adorned with emeralds.",
               Category = "Earrings",
               ImageUrl = "Diamond Solitaire Necklace.jpg",
               Price = 1200
           },
           new Product
           {
               Id = 3,
               Name = "Sapphire and Diamond Ring",
               Description = "A beautiful ring with a sapphire gemstone surrounded by diamonds.",
               Category = "Ring",
               ImageUrl = "Diamond Solitaire Necklace.jpg",
               Price = 1800
           },
           new Product
           {
               Id = 4,
               Name = "Gold Chain Bracelet",
               Description = "A classic gold chain bracelet.",
               Category = "Bracelet",
               ImageUrl = "Diamond Solitaire Necklace.jpg",
               Price = 800
           },
           new Product
           {
               Id = 5,
               Name = "Pearl Drop Earrings",
               Description = "Elegant earrings with pearl drop accents.",
               Category = "Earrings",
               ImageUrl = "Diamond Solitaire Necklace.jpg",
               Price = 1000
           },
           new Product
           {
               Id = 6,
               Name = "Ruby Tennis Bracelet",
               Description = "A tennis bracelet adorned with rubies.",
               Category = "Bracelet",
               ImageUrl = "Diamond Solitaire Necklace.jpg",
               Price = 1600
           },
           new Product
           {
               Id = 7,
               Name = "Opal Pendant Necklace",
               Description = "A necklace featuring a pendant with a stunning opal gemstone.",
               Category = "Necklace",
               ImageUrl = "Diamond Solitaire Necklace.jpg",
               Price = 1400
           },
           new Product
           {
               Id = 8,
               Name = "Amethyst Cluster Ring",
               Description = "A ring adorned with a cluster of amethyst gemstones.",
               Category = "Ring",
               ImageUrl = "Diamond Solitaire Necklace.jpg",
               Price = 1100
           },
           new Product
           {
               Id = 9,
               Name = "Topaz Chandelier Earrings",
               Description = "Chandelier-style earrings featuring topaz gemstones.",
               Category = "Earrings",
               ImageUrl = "Diamond Solitaire Necklace.jpg",
               Price = 1300
           },
           new Product
           {
               Id = 10,
               Name = "Platinum Wedding Band",
               Description = "A sleek platinum wedding band.",
               Category = "Ring",
               ImageUrl = "Diamond Solitaire Necklace.jpg",
               Price = 2000
           });
    }
}
