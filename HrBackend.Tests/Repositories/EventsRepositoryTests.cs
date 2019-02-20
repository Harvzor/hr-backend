
using Xunit;
using HrBackend.Repositories;
using System.Linq;

namespace HrBackend.Tests
{
    public class EventsRepositoryTests
    {
        private readonly IEventsRepository _eventsRepository;

        public EventsRepositoryTests()
        {
        }

        [Fact]
        public void GetAllEventsTest()
        {
            var result = _eventsRepository.GetAllEvents();

            Assert.True(result.ToList().Count() > 0);
        }
    }
}
