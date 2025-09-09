using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace topMedic.EntityFramework;
public class TopMedicDbContextFactory : IDesignTimeDbContextFactory<TopMedicDbContext>
{
    public TopMedicDbContext CreateDbContext(string[] args = null)
    {
        var options = new DbContextOptionsBuilder<TopMedicDbContext>();

        options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=topMedicDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        return new TopMedicDbContext(options.Options);
    }
}
