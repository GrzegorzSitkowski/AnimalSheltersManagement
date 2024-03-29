﻿using AnimalShelterManagement.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Persistance
{
    public static  class DepedencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShelterDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ShelterDatabase")));

            services.AddScoped<IShelterDbContext, ShelterDbContext>();

            return services;
        }
    }
}
