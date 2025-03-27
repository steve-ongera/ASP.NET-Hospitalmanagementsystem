using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    [Table("doctor")] // Tell EF to map this class to the "doctor" table exactly
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
