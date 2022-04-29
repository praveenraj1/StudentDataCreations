using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using StudentDataCraetion.Repository.Repository;
using StudentDataCreation.Core.IRepository;
using StudentDataCreation.Core.IServices;
using StudentDataCreation.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataCreation.Utility
{
   public class DIResolver
    {

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IServices, StudentsServices>();

            services.AddScoped<IRepository, StudentsRepository>();
        }

    }
}
