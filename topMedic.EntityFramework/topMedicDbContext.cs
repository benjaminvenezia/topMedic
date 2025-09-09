using Microsoft.EntityFrameworkCore;
using topMedic.Domain.Models;

namespace topMedic.EntityFramework;
public class TopMedicDbContext : DbContext
{
 

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }


    public TopMedicDbContext(DbContextOptions options) : base(options){}

}
