using erp.domain.Entities;
using erp.infra.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace erp.infra.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Product> Products {get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new ProductConfiguration());
    }
}