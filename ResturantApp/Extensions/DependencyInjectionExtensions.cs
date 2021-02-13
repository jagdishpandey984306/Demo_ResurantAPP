using Microsoft.Extensions.DependencyInjection;
using Resturant.Business.Customer;
using Resturant.Repository.Customer;
using Resturant.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantApp.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection RegisterAllDependencies(this IServiceCollection services)
        {
            services.AddTransient<IDapperDao, DapperDao>();
            services.AddTransient<ICustomerBuisness, CustomerBusiness>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
