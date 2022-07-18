using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.BLL.Services;

namespace UniversityApp.BLL
{
    public static class BllDependency
    {
        public static IServiceCollection AddBllDependency( this IServiceCollection service)
        {
            service.AddScoped<IDepartmentService, DepartmentService>();
            return service;
        }
    }
}
