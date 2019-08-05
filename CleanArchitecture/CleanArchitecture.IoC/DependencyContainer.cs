using CleanArchitecture.ApplicationCore.Interfaces;
using CleanArchitecture.ApplicationCore.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //  application layer

            services.AddScoped<ICourseService, CourseService>();


            //  infrastructure data layer

            services.AddTransient<ICourseRepository, CourseRepository>();
        }



    }
}
