using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Cupcakes.Data;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using Microsoft.AspNetCore.Identity.UI.Pages.Internal.Account;
using Cupcakes.Repositories;
using System.Reflection.Metadata;

namespace Cupcakes
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICupcakeRepository, CupcakeRepository>();
            services.AddDbContext<CupcakeContext>(options =>
                   options.UseSqlServer(_configuration.GetConnectionString("keyCupcake")));
            services.AddMvc();
        }

        public void Configure()
        {
                      
        }
    }
}
