using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnversityApp.DLL.Repository;
using UnversityApp.DLL.UOW;

namespace UnversityApp.DLL
{
    public static class DllDependency
    {
        public static IServiceCollection AddDllDependency(this IServiceCollection service)
        {
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<IDepartmentRepository, DepartmentRepository>();
            return service;
        }
    }
}
