using erp.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace erp.infra.EntityConfiguration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.OrderDate)
               //.HasDefaultValueSql("CURRENT_TIMESTAMP")
               .IsRequired();

        builder.Property(o => o.GlobalDiscount)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.Property(o => o.ShippingCost)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.Property(o => o.AdditionalExpenses)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.Property(o => o.Status)
               .IsRequired();

        builder.HasOne(o => o.Customer);

        builder.HasMany(o => o.OrderItems)
               .WithOne(oi => oi.Order)
               .HasForeignKey(oi => oi.OrderId)
               .OnDelete(DeleteBehavior.Cascade);

        //builder.Ignore(o => o.TotalAmount); // Ignorar a propriedade calculada
    }
}
