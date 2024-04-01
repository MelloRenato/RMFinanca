using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RMFinanca.Data;

namespace RMFinanca
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FinancaDataContext>(
                options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("DefaultConnection"),
                        x => x.MigrationsAssembly("RMFinanca.Migrations")));
        }

    }
}
