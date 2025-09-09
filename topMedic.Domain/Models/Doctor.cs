namespace topMedic.Domain.Models;

public class Doctor
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<Patient> Patients { get; set; } = new List<Patient>();
    public List<Appointment> Appointments { get; set; } = new List<Appointment>();

    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

}