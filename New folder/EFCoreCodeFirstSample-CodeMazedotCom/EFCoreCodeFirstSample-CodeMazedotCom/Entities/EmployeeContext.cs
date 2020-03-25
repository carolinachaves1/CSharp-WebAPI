using EFCoreCodeFirstSample_CodeMazedotCom.Models;
using Microsoft.EntityFrameworkCore;


namespace EFCoreCodeFirstSample_CodeMazedotCom.Entities
{

    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {

        }

        public static string BaseDirectory { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Uncle",
                LastName = "Bob",
                Email = "uncle.bob@gmail.com",
                DateOfBirth = new System.DateTime(1979, 04, 25),
                PhoneNumber = "999-888-777"
            }, new Employee
            {
                EmployeeId = 2,
                FirstName = "Nice",
                LastName = "Good",
                Email = "nice.good@gmail.com",
                DateOfBirth = new System.DateTime(1980, 02, 22),
                PhoneNumber = "111-222-333"
            }, new Employee
            {
                EmployeeId = 3,
                FirstName = "Ben",
                LastName = "Jovi",
                Email = "ben.jovi@gmail.com",
                DateOfBirth = new System.DateTime(1990, 12, 02),
                PhoneNumber = "555-444-333"
            });
        }
    }
}
