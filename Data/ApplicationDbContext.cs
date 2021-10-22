using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POSWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<StudentCourse>().HasKey(sc=> new { sc.StudentId, sc.CourseId});
            builder.Entity<PatientDrugs>().HasKey(pd=> new { pd.PatientId, pd.DrugId});
            builder.Entity<EmployeeBranch>().HasKey(sc => new { sc.EmployeeId, sc.BranchId });
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Course> Course { get; set; }

        public DbSet<Student> Student { get; set; }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Drugs> Drugs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }
}
