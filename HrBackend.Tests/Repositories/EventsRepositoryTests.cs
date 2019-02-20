
using Xunit;
using HrBackend.Repositories;

namespace HrBackend.Tests
{
    public class EventsRepositoryTests
    {
        private readonly EventsRepository _eventsRepository;

        [Fact]
        public void GetAllEventsTest()
        {
            var result = _eventsRepository.GetAllEvents();

            Assert.True(result.Count() > 0);
        }
    }
}
