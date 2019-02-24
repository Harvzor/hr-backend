using HrBackend.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HrBackend.Tests
{
    public class TestStartup
    {
        public TestStartup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddDbContext<EventsContext>(options =>
                    options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"))
                );

            // This should probably be transient so the EventsRepository is created each time.
            services
                .AddTransient<IEventsRepository, EventsRepository>();
        }
    }
}
