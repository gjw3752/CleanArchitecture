using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ApplicationCore.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }

    }
}
