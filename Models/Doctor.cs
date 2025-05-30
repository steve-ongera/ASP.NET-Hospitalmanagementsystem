using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    [Table("doctor")] // Tell EF to map this class to the "doctor" table exactly
    public class Doctor
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Specialty { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
    }
}
