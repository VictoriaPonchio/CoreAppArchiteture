using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreAppArchiteture.Infrastructure.Config
{
    public static class StartupSetup
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<CoreAppContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CoreArchitetureDB")));
    }
}

