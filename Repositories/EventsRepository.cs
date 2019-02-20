
using System;
using System.Collections.Generic;
using HrBackend.Models;

namespace HrBackend.Repositories
{
    public interface IEventsRepository
    {
        IEnumerable<Event> GetAllEvents();
        Event GetEvent(string id);
    }

    public class EventsRepository : IEventsRepository
    {
        public IEnumerable<Event> GetAllEvents()
        {
            return new List<Event>() {
                new Event()
                {
                    Name = "First Lesson",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now
                }
            };
        }

        public Event GetEvent(string id)
        {
            return new Event()
            {
                Name = "First Lesson",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            };
        }
    }
}
