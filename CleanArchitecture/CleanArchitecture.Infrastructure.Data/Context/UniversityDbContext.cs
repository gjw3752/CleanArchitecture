using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }


        public UniversityDbContext(DbContextOptions options) : base(options)
        {
        }






    }
}
