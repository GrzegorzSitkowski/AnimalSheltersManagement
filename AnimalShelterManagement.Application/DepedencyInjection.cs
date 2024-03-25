using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AnimalShelterManagement.Application
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
          
            return services;
        }
    }
}
