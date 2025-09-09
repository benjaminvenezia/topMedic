using Microsoft.EntityFrameworkCore;
using topMedic.Domain.Models;

namespace topMedic.EntityFramework;
public class topMedicDbContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        base.OnConfiguring(optionsBuilder);
    }
}
