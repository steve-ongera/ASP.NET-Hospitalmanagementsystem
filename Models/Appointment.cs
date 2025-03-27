using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        
        public required virtual Patient Patient { get; set; } // Navigation property

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public required virtual Doctor Doctor { get; set; } // Navigation property

        [Required]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan AppointmentTime { get; set; }

        [Required]
        [StringLength(50)]
        public required string Status { get; set; } // E.g., "Scheduled", "Completed", "Canceled"
    }
}
