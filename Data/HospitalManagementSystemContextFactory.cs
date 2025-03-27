using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Data
{
    public class HospitalManagementSystemContextFactory : IDesignTimeDbContextFactory<HospitalManagementSystemContext>
    {
        public HospitalManagementSystemContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HospitalManagementSystemContext>();

            // Replace with your actual connection string!
            var connectionString = "server=localhost;port=3306;database=hospitaldb;user=root;password=cp7kvt;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new HospitalManagementSystemContext(optionsBuilder.Options);
        }
    }
}
