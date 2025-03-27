using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    [Table("patients")] // maps exactly to the 'patients' table in MySQL
    public class Patient
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string  Phone { get; set; }
        public required string Email { get; set; }
        public required string Address { get; set; }
        public int Age { get; set; }
        public required string Gender { get; set; } // Male, Female, Other
    }
}
