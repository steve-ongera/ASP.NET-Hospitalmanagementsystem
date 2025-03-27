using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Data
{
    public class HospitalManagementSystemContext : DbContext
    {
        public HospitalManagementSystemContext(DbContextOptions<HospitalManagementSystemContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
