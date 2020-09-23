using Microsoft.Extensions.DependencyInjection;
using ProductivityTools.BankAccounts.Database;
using ProductivityTools.DateTimeTools;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProductivityTools.BankAccounts.Commands
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
