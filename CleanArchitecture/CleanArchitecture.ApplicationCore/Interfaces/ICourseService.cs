using CleanArchitecture.ApplicationCore.ViewModels;
using System.Collections.Generic;

namespace CleanArchitecture.ApplicationCore.Interfaces
{
    public interface ICourseService
    {

        CourseViewModel GetCourses();
    }
}
