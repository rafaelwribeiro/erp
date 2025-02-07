using erp.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace erp.infra.EntityConfiguration;

public class OrderPaymentConfiguration : IEntityTypeConfiguration<OrderPayment>
{
    public void Configure(EntityTypeBuilder<OrderPayment> builder)
    {
        builder.HasKey(x => x.OrderId);

        builder.Property(oi => oi.Amount)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.HasOne(x => x.Order);
    }
}
