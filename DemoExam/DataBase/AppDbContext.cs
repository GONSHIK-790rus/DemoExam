using DemoExam.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoExam.DataBase;

public partial class AppDbContext : DbContext {
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MaterialType> MaterialTypes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductMaterial> ProductMaterials { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-VD7T692\\SQLEXPRESS;Database=demo_exam;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Material>(entity => {
            entity.HasOne(material => material.ТипМатериалаNavigation)
                .WithMany(materialType => materialType.Materials)
                .HasConstraintName("FK_materials_material_types");
        });

        modelBuilder.Entity<Product>(entity => {
            entity.HasOne(product => product.ТипПродукцииNavigation)
                .WithMany(productType => productType.Products)
                .HasConstraintName("FK_products_product_types");
        });

        modelBuilder.Entity<ProductMaterial>(entity => {
            entity.HasOne(productMaterial => productMaterial.НаименованиеМатериалаNavigation)
                .WithMany(material => material.ProductMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_product_materials_materials");

            entity.HasOne(productMaterial => productMaterial.ПродукцияNavigation)
                .WithMany(product => product.ProductMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_product_materials_products");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
