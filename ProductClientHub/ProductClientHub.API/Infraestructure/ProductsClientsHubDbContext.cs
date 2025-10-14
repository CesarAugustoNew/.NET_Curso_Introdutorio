using Microsoft.EntityFrameworkCore;
using ProductClientHub.API.Entities;

namespace ProductClientHub.API.Infraestructure;

public class ProductsClientsHubDbContext : DbContext
{
    public DbSet <Client> Clients {  get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\Pichau\\Downloads\\1737062251373-attachment (1).octet-stream");
    }
}
