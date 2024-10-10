using erp.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace erp.infra.EntityConfiguration;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasKey(oi => oi.Id);

        builder.Property(oi => oi.Quantity)
               .IsRequired();

        builder.Property(oi => oi.UnitPrice)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.Property(oi => oi.Discount)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        /*builder.Property(oi => oi.TotalPrice)
               .HasColumnType("decimal(18,2)")
               .IsRequired();*/
        
        builder.HasOne(oi => oi.Product);

        builder.HasOne(oi => oi.Order);
    }

    /*
      public int OrderId { get; set; }
    public Order? Order { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; } // Desconto por item
    public decimal TotalPrice => Quantity * UnitPrice - Discount;
     */
}
