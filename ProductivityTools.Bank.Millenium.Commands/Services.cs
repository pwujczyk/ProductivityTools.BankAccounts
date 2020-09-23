using Microsoft.Extensions.DependencyInjection;
using ProductivityTools.Bank.Millenium.Database;
using ProductivityTools.DateTimeTools;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProductivityTools.Bank.Millenium.Commands
{
    public static class Services
    {
        public static void ConfigureServicesCommands(this IServiceCollection services)
        {
            services.AddScoped<IBMCommands, BMCommands>();
            services.AddScoped<IDateTimePT, DateTimePT>();
            services.RegisterServicesDatabase();
        }
    }
}
