using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreDemo;

public class EFCoreDemoContext : DbContext
{
    public DbSet<Department> Departments { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer($"Server = .; Database = EFCoreDB; Integrated Security = True; encrypt = True; TrustServerCertificate = True;");
    }
}
