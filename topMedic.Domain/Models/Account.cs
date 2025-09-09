namespace topMedic.Domain.Models;

public class Account
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public Doctor DoctorProfile { get; set; }
    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;



}