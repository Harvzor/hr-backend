using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace HrBackend.Tests.Contexts
{
    public class EventsWithDatabaseContext
    {
        public EventsWithDatabaseContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private  IConfiguration Configuration { get; }

        /*
            public static async Task Run(Func testFunc)
            {
                var options = new DbContextOptionsBuilder()
                    .UseNpgsql(Configuration.GetConnectionString("DefaultConnection"))
                    .Options;

                using (var context = new EventsContext(options))
                {
                    try
                    {
                        await context.Database.EnsureCreatedAsync();
                        //PrepareTestDatabase(context);
                        await testFunc(context);
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        //CleanupTestDatabase(context);
                    }
                }
            }
        */
    }
}
