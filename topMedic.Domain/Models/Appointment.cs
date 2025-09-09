﻿

namespace topMedic.Domain.Models;



public enum AppointmentStatus
{
    Scheduled,
    Completed,
    Cancelled
}

public class Appointment
{
    public int Id { get; set; }
    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string ConsultationReason { get; set; }
    public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;
    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;


}