using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _context;


        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }


    }
}
