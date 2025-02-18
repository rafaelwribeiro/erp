using erp.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace erp.infra.EntityConfiguration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
        builder.Property(p => p.Price).HasDefaultValue(0).HasColumnType("DECIMAL(10,4)").IsRequired();
        builder.Property(p => p.Cost).HasDefaultValue(0).HasColumnType("DECIMAL(10,4)").IsRequired();
        builder.Property(p => p.StockQuantity).HasDefaultValue(0).IsRequired();
        builder.Property(p => p.BarCode).HasMaxLength(20);
        builder.HasIndex(p => p.BarCode);
    }
}