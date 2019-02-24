using Xunit;
using HrBackend.Repositories;
using System.Linq;
using HrBackend.Tests.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;

namespace HrBackend.Tests
{
    public class EventsRepositoryTests
    {
        private readonly IEventsRepository _eventsRepository;
        
        /// <see>
        /// https://stackoverflow.com/questions/37724738/how-to-unit-test-asp-net-core-application-with-constructor-dependency-injection
        /// </see>
        public EventsRepositoryTests()
        {
            var services = new ServiceCollection();

            services
                .AddDbContext<EventsContext>(options =>
                    //options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"))
                    options.UseNpgsql("User ID=postgres;Password=password;Server=localhost;Port=5432;Database=postgres;Integrated Security=true;Pooling=true")
                );

            services.AddTransient<IEventsRepository, EventsRepository>();

            var serviceProvider = services.BuildServiceProvider();

            _eventsRepository = serviceProvider.GetService<IEventsRepository>();
        }

        /*
            private async void Setup()
            {
                var eventsWithDatabaseContext = new EventsWithDatabaseContext();

                await eventsWithDatabaseContext.Run(async (EventsContext context) =>
                {
                    var eventsRepository = new EventsRepository(context);
                });
            }
        */

        [Fact]
        public async void GetAllEventsTest()
        {
            var result = await _eventsRepository.GetAllEvents();

            Assert.True(result.ToList().Count() > 0);
        }
    }
}
