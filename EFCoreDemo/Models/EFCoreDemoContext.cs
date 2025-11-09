using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace EFCoreDemo.Models;

public class EFCoreDemoContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer($"Server = .; Database = EFCoreDB; Integrated Security = True; encrypt = True; TrustServerCertificate = True;");
        var configBuilder = new ConfigurationBuilder();
        var configuration = configBuilder.AddJsonFile("appsetting.json").Build();
        var configSection = configuration.GetSection("ConnectionStrings");
        var connectionString = configSection["DBConnection"];
        optionsBuilder.UseSqlServer(connectionString);
    }
}
