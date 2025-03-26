using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Data
{
    public class HospitalManagementSystemContext : DbContext
    {
        public HospitalManagementSystemContext(DbContextOptions<HospitalManagementSystemContext> options) : base(options) { }

        public DbSet<HospitalManagementSystem.Models.Patient> Patients { get; set; }
        public DbSet<HospitalManagementSystem.Models.Appointment> Appointments { get; set; }
    }
}
