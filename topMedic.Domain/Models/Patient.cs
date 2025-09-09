namespace topMedic.Domain.Models;

public class Patient: DomainObject
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string BloodGroup { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

}