
using System;
using System.Collections.Generic;
using HrBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace HrBackend.Repositories
{
    public interface IEventsRepository
    {
        IEnumerable<Event> GetAllEvents();
        Event GetEvent(string id);
    }

    public class EventsRepository : IEventsRepository
    {
        private readonly EventsContext _context = null;

        public EventsRepository(DbContextOptions<EventsContext> options)
        {
            _context = new EventsContext(options);
        }

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
