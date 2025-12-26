using Microsoft.EntityFrameworkCore;

namespace StoreApp.Data.Concrete;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasMany(e => e.Categories)
            .WithMany(e => e.Products)
            .UsingEntity<ProductCategory>();

        modelBuilder.Entity<Category>()
            .HasIndex(u => u.Url)
            .IsUnique();

        modelBuilder.Entity<Product>().HasData(
            new List<Product>() {
                new() { Id=1, Name="Iphone 16 256GB", Price=60000, Description="Siyah renk, Apple Iphone"},
                new() { Id=2, Name="Iphone 17Pro Max", Price=99000, Description="Turuncu, Büyük Ekran Apple Iphone"},
                new() { Id=3, Name="Iphone 15 256Gb", Price=50000, Description="Bebek mavisi, Apple Iphone"},
                new() { Id=4, Name="Samsung S27", Price=80000, Description="Android, kaliteli kamera, Samsung telefon"},
                new() { Id=5, Name="Playstation 5", Price=45000, Description="Yanında God Of War hediyeli"},
                new() { Id=6, Name="Dyson AirWrap", Price=28000, Description="Saçlarınız müthiş olacak!"},
            }
        );

        modelBuilder.Entity<Category>().HasData(
            new List<Category>() {
                new () { Id = 1,  Name = "Telefon", Url = "telefon"},
                new () { Id = 2,  Name = "Elektronik", Url = "elektronik"},
                new () { Id = 3,  Name = "Beyaz Eşya", Url = "beyaz-esya"}  // extension method, slug dotnet 
            }
        );

        modelBuilder.Entity<ProductCategory>().HasData(
            new List<ProductCategory>() {
                new ProductCategory() { ProductId=1, CategoryId=1},
                new ProductCategory() { ProductId=2, CategoryId=1},
                new ProductCategory() { ProductId=3, CategoryId=1},
                new ProductCategory() { ProductId=4, CategoryId=1},
                new ProductCategory() { ProductId=5, CategoryId=2},
                new ProductCategory() { ProductId=6, CategoryId=2},
            }
        );

    }
}