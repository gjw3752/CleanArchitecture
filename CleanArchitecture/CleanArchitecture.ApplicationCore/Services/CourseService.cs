using CleanArchitecture.ApplicationCore.Interfaces;
using CleanArchitecture.ApplicationCore.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ApplicationCore.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;



        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }



    }
}
