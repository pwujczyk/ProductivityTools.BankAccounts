using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Bank.Millenium.Database
{
    public static class Services
    {
        public static void RegisterServicesDatabase(this IServiceCollection services)
        {
            services.AddScoped<MilleniumContext>();
        }
    }
}
